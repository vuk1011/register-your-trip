using Domen;
using PoslovnaLogika;
using System.Net.Sockets;
using Zajednicko;

namespace AplikacijaServer
{
    internal class ClientHandler
    {
        private Socket socket;
        private JsonSerijalizator serijalizator;
        private Kontroler kontroler;

        public ClientHandler(Socket socket)
        {
            this.socket = socket;
            serijalizator = new JsonSerijalizator(socket);
            kontroler = new Kontroler();
        }

        public void Handle()
        {
            try
            {
                while (true)
                {
                    Zahtev z = serijalizator.Receive<Zahtev>();
                    Odgovor o = ObradiZahtev(z);
                    serijalizator.Send(o);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Грешка: " + ex.Message);
            }
            finally
            {
                serijalizator.Close();
                socket.Shutdown(SocketShutdown.Both);
                socket.Close();
            }
        }

        public Odgovor ObradiZahtev(Zahtev z)
        {
            Odgovor o = new Odgovor
            {
                Signal = true
            };
            try
            {
                switch (z.Operacija)
                {
                    case Operacija.PostojiStanovnik:
                        Stanovnik s1 = serijalizator.ReadType<Stanovnik>(z.Podaci);
                        o.Podaci = kontroler.PostojiStanovnik(s1);
                        break;
                    case Operacija.PostojiStanovnikZaJmbgPasos:
                        Stanovnik s2 = serijalizator.ReadType<Stanovnik>(z.Podaci);
                        o.Podaci = kontroler.PostojiStanovnikSaJmbgIBrojPasosa(s2);
                        break;
                    case Operacija.VratiDrzavaEU:
                        var drzaveEU = kontroler.VratiDrzavaEU();
                        o.Podaci = drzaveEU;
                        break;
                    case Operacija.PostojiKorisnikSaUsername:
                        string username = serijalizator.ReadType<string>(z.Podaci);
                        o.Podaci = kontroler.PostojiKorisnikSaUsername(username);
                        break;
                    case Operacija.PostojiKorisnikZaStanovnika:
                        Stanovnik s3 = serijalizator.ReadType<Stanovnik>(z.Podaci);
                        o.Podaci = kontroler.PostojiKorisnikZaStanovnika(s3);
                        break;
                    case Operacija.PrijaviKorisnika:
                        Korisnik k1 = serijalizator.ReadType<Korisnik>(z.Podaci);
                        o.Podaci = kontroler.PrijaviKorisnika(k1);
                        break;
                    case Operacija.DodajKorisnika:
                        Korisnik k2 = serijalizator.ReadType<Korisnik>(z.Podaci);
                        kontroler.DodajKorisnika(k2);
                        break;
                    case Operacija.VratiPrijave:
                        string jmbg = serijalizator.ReadType<string>(z.Podaci);
                        var prijave = kontroler.VratiPrijave(jmbg);
                        o.Podaci = prijave;
                        break;
                    case Operacija.DodajPrijavu:
                        Prijava p1 = serijalizator.ReadType<Prijava>(z.Podaci);
                        kontroler.DodajPrijavu(p1);
                        break;
                    case Operacija.IzmeniPrijavu:
                        Prijava p2 = serijalizator.ReadType<Prijava>(z.Podaci);
                        kontroler.IzmeniPrijavu(p2);
                        break;
                    case Operacija.ObrisiPrijavu:
                        Prijava p3 = serijalizator.ReadType<Prijava>(z.Podaci);
                        kontroler.ObrisiPrijavu(p3);
                        break;
                    default:
                        throw new Exception("Операција не постоји");
                }
            }
            catch (Exception ex)
            {
                o.Poruka = ex.Message;
                o.Signal = false;
            }
            return o;
        }
    }
}
