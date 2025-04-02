using Domen;
using System.Net.Sockets;
using Zajednicko;

namespace AplikacijaKlijent.KontrolerKI
{
    internal class Kontroler
    {
        private static Kontroler? instanca;
        private Socket soket;
        private JsonSerijalizator? serijalizator;
        public static Kontroler Instanca
        {
            get
            {
                if (instanca is null)
                {
                    instanca = new Kontroler();
                }
                return instanca;
            }
        }

        public Kontroler()
        {
            soket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }

        public void PoveziSe()
        {
            try
            {
                soket.Connect(ServerData.endPoint);
                serijalizator = new JsonSerijalizator(soket);
            }
            catch (SocketException)
            {
                throw new Exception("Неуспешно повезивање са сервером.");
            }
        }

        public void Zatvori()
        {
            try
            {
                serijalizator?.Close();
                if (soket != null && soket.Connected)
                {
                    soket.Shutdown(SocketShutdown.Both);
                }
                soket?.Close();
            }
            catch (SocketException)
            {
                throw new Exception("Грешка при затварању.");
            }
        }

        public bool PostojiStanovnik(Stanovnik s)
        {
            try
            {
                Zahtev z = new Zahtev
                {
                    Operacija = Operacija.PostojiStanovnik,
                    Podaci = s
                };
                serijalizator.Send(z);
                Odgovor o = serijalizator.Receive<Odgovor>();
                if (o.Signal)
                {
                    var rezultat = serijalizator.ReadType<bool>(o.Podaci);
                    return rezultat;
                }
                else
                {
                    throw new Exception(o.Poruka);
                }
            }
            catch (IOException)
            {
                throw new Exception("Грешка у комуникацији.");
            }
            catch (SocketException)
            {
                throw new Exception("Грешка у комуникацији.");
            }
        }

        public bool PostojiStanovnikSaJmbgIBrojPasosa(Stanovnik s)
        {
            try
            {
                Zahtev z = new Zahtev
                {
                    Operacija = Operacija.PostojiStanovnikZaJmbgPasos,
                    Podaci = s
                };
                serijalizator.Send(z);
                Odgovor o = serijalizator.Receive<Odgovor>();
                if (o.Signal)
                {
                    var rezultat = serijalizator.ReadType<bool>(o.Podaci);
                    return rezultat;
                }
                else
                {
                    throw new Exception(o.Poruka);
                }
            }
            catch (IOException)
            {
                throw new Exception("Грешка у комуникацији.");
            }
            catch (SocketException)
            {
                throw new Exception("Грешка у комуникацији.");
            }
        }

        public List<DrzavaEU> VratiDrzavaEU()
        {
            try
            {
                Zahtev z = new Zahtev
                {
                    Operacija = Operacija.VratiDrzavaEU
                };
                serijalizator.Send(z);
                Odgovor o = serijalizator.Receive<Odgovor>();
                if (o.Signal)
                {
                    var rezultat = serijalizator.ReadType<List<DrzavaEU>>(o.Podaci);
                    return rezultat;
                }
                else
                {
                    throw new Exception(o.Poruka);
                }
            }
            catch (IOException)
            {
                throw new Exception("Грешка у комуникацији.");
            }
            catch (SocketException)
            {
                throw new Exception("Грешка у комуникацији.");
            }
        }

        public bool PostojiKorisnikSaUsername(string user)
        {
            try
            {
                Zahtev z = new Zahtev
                {
                    Operacija = Operacija.PostojiKorisnikSaUsername,
                    Podaci = user
                };
                serijalizator.Send(z);
                Odgovor o = serijalizator.Receive<Odgovor>();
                if (o.Signal)
                {
                    var rezultat = serijalizator.ReadType<bool>(o.Podaci);
                    return rezultat;
                }
                else
                {
                    throw new Exception(o.Poruka);
                }
            }
            catch (IOException)
            {
                throw new Exception("Грешка у комуникацији.");
            }
            catch (SocketException)
            {
                throw new Exception("Грешка у комуникацији.");
            }
        }

        public bool PostojiKorisnikZaStanovnika(Stanovnik s)
        {
            try
            {
                Zahtev z = new Zahtev
                {
                    Operacija = Operacija.PostojiKorisnikZaStanovnika,
                    Podaci = s
                };
                serijalizator.Send(z);
                Odgovor o = serijalizator.Receive<Odgovor>();
                if (o.Signal)
                {
                    var rezultat = serijalizator.ReadType<bool>(o.Podaci);
                    return rezultat;
                }
                else
                {
                    throw new Exception(o.Poruka);
                }
            }
            catch (IOException)
            {
                throw new Exception("Грешка у комуникацији.");
            }
            catch (SocketException)
            {
                throw new Exception("Грешка у комуникацији.");
            }
        }

        public Korisnik PrijaviKorisnika(Korisnik k)
        {
            try
            {
                Zahtev z = new Zahtev
                {
                    Operacija = Operacija.PrijaviKorisnika,
                    Podaci = k
                };
                serijalizator.Send(z);
                Odgovor o = serijalizator.Receive<Odgovor>();
                if (o.Signal)
                {
                    var rezultat = serijalizator.ReadType<Korisnik>(o.Podaci);
                    return rezultat;
                }
                else
                {
                    throw new Exception(o.Poruka);
                }
            }
            catch (IOException)
            {
                throw new Exception("Грешка у комуникацији.");
            }
            catch (SocketException)
            {
                throw new Exception("Грешка у комуникацији.");
            }
        }

        public void DodajKorisnika(Korisnik k)
        {
            try
            {
                Zahtev z = new Zahtev
                {
                    Operacija = Operacija.DodajKorisnika,
                    Podaci = k
                };
                serijalizator.Send(z);
                Odgovor o = serijalizator.Receive<Odgovor>();
                if (!o.Signal)
                {
                    throw new Exception(o.Poruka);
                }
            }
            catch (IOException)
            {
                throw new Exception("Грешка у комуникацији.");
            }
            catch (SocketException)
            {
                throw new Exception("Грешка у комуникацији.");
            }
        }

        public List<Prijava> VratiPrijave(string jmbg)
        {
            try
            {
                Zahtev z = new Zahtev
                {
                    Operacija = Operacija.VratiPrijave,
                    Podaci = jmbg
                };
                serijalizator.Send(z);
                Odgovor o = serijalizator.Receive<Odgovor>();
                if (o.Signal)
                {
                    var rezultat = serijalizator.ReadType<List<Prijava>>(o.Podaci);
                    return rezultat;
                }
                else
                {
                    throw new Exception(o.Poruka);
                }
            }
            catch (IOException)
            {
                throw new Exception("Грешка у комуникацији.");
            }
            catch (SocketException)
            {
                throw new Exception("Грешка у комуникацији.");
            }
        }

        public void DodajPrijavu(Prijava p)
        {
            try
            {
                Zahtev z = new Zahtev
                {
                    Operacija = Operacija.DodajPrijavu,
                    Podaci = p
                };
                serijalizator.Send(z);
                Odgovor o = serijalizator.Receive<Odgovor>();
                if (!o.Signal)
                {
                    throw new Exception(o.Poruka);
                }
            }
            catch (IOException)
            {
                throw new Exception("Грешка у комуникацији.");
            }
            catch (SocketException)
            {
                throw new Exception("Грешка у комуникацији.");
            }
        }

        public void IzmeniPrijavu(Prijava p)
        {
            try
            {
                Zahtev z = new Zahtev
                {
                    Operacija = Operacija.IzmeniPrijavu,
                    Podaci = p
                };
                serijalizator.Send(z);
                Odgovor o = serijalizator.Receive<Odgovor>();
                if (!o.Signal)
                {
                    throw new Exception(o.Poruka);
                }
            }
            catch (IOException)
            {
                throw new Exception("Грешка у комуникацији.");
            }
            catch (SocketException)
            {
                throw new Exception("Грешка у комуникацији.");
            }
        }

        public void ObrisiPrijavu(Prijava p)
        {
            try
            {
                Zahtev z = new Zahtev
                {
                    Operacija = Operacija.ObrisiPrijavu,
                    Podaci = p
                };
                serijalizator.Send(z);
                Odgovor o = serijalizator.Receive<Odgovor>();
                if (!o.Signal)
                {
                    throw new Exception(o.Poruka);
                }
            }
            catch (IOException)
            {
                throw new Exception("Грешка у комуникацији.");
            }
            catch (SocketException)
            {
                throw new Exception("Грешка у комуникацији.");
            }
        }
    }
}
