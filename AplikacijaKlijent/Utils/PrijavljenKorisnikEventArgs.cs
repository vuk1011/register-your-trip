using Domen;

namespace AplikacijaKlijent.Utils
{
    public class PrijavljenKorisnikEventArgs : EventArgs
    {
        public Korisnik Korisnik { get; private set; }

        public PrijavljenKorisnikEventArgs(Korisnik korisnik)
        {
            Korisnik = korisnik;
        }
    }
}
