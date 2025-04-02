using Domen;
using BrokerBP = BrokerBazePodataka.BrokerBazePodataka;

namespace PoslovnaLogika
{
    public class Kontroler
    {
        private BrokerBP bbp = new BrokerBP();

        public bool PostojiStanovnik(Stanovnik s)
        {
            try
            {
                bbp.ConnectBPStanovnistvo();
                return bbp.PostojiStanovnik(s);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            finally
            {
                bbp.Disconnect();
            }
        }

        public bool PostojiStanovnikSaJmbgIBrojPasosa(Stanovnik s)
        {
            try
            {
                bbp.ConnectBPStanovnistvo();
                return bbp.PostojiStanovnikSaJmbgIBrojPasosa(s);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            finally
            {
                bbp.Disconnect();
            }
        }

        public List<DrzavaEU> VratiDrzavaEU()
        {
            try
            {
                bbp.ConnectBPPrijavaPutovanja();
                return bbp.VratiDrzavaEU();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            finally
            {
                bbp.Disconnect();
            }
        }

        public bool PostojiKorisnikSaUsername(string user)
        {
            try
            {
                bbp.ConnectBPPrijavaPutovanja();
                return bbp.PostojiKorisnikSaUsername(user);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            finally
            {
                bbp.Disconnect();
            }
        }

        public bool PostojiKorisnikZaStanovnika(Stanovnik s)
        {
            try
            {
                bbp.ConnectBPPrijavaPutovanja();
                return bbp.PostojiKorisnikZaStanovnika(s);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            finally
            {
                bbp.Disconnect();
            }
        }

        public Korisnik PrijaviKorisnika(Korisnik k)
        {
            try
            {
                bbp.ConnectBPPrijavaPutovanja();
                return bbp.PrijaviKorisnika(k);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            finally
            {
                bbp.Disconnect();
            }
        }

        public void DodajKorisnika(Korisnik k)
        {
            try
            {
                bbp.ConnectBPPrijavaPutovanja();
                bbp.DodajKorisnika(k);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            finally
            {
                bbp.Disconnect();
            }
        }

        public List<Prijava> VratiPrijave(string jmbg)
        {
            try
            {
                bbp.ConnectBPPrijavaPutovanja();
                return bbp.VratiPrijave(jmbg);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            finally
            {
                bbp.Disconnect();
            }
        }

        public void DodajPrijavu(Prijava p)
        {
            try
            {
                bbp.ConnectBPPrijavaPutovanja();
                bbp.DodajPrijavu(p);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            finally
            {
                bbp.Disconnect();
            }
        }

        public void IzmeniPrijavu(Prijava p)
        {
            try
            {
                bbp.ConnectBPPrijavaPutovanja();
                bbp.IzmeniPrijavu(p);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            finally
            {
                bbp.Disconnect();
            }
        }

        public void ObrisiPrijavu(Prijava p)
        {
            try
            {
                bbp.ConnectBPPrijavaPutovanja();
                bbp.ObrisiPrijavu(p);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            finally
            {
                bbp.Disconnect();
            }
        }
    }
}
