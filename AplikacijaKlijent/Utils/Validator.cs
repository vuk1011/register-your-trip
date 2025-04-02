using Domen;
using System.Text.RegularExpressions;

namespace AplikacijaKlijent.Utils
{
    internal class Validator
    {
        public static void PrikaziUspesno(string poruka)
        {
            MessageBox.Show(poruka, "Успешно :)", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
 
        public static void PrikaziGresku(string poruka)
        {
            MessageBox.Show(poruka, "Грешка :(", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static bool JeCirilicno(string s)
        {
            string patern = @"^[ЉЊЕРТЗУИОПШЂАСДФГХЈКЛЧЋЖЏЦВБНМ]+$";
            return Regex.IsMatch(s, patern);
        }

        public static bool JeNumericko(string s)
        {
            string patern = @"^\d+$";
            return Regex.IsMatch(s, patern);
        }

        public static bool ValidnoIme(string s)
        {
            s = s.Trim();
            if (string.IsNullOrEmpty(s))
            {
                return false;
            }
            if (s.Contains(' '))
            {
                return false;
            }
            if (!JeCirilicno(s))
            {
                return false;
            }
            return true;
        }

        public static bool ValidanBrPasosa(string s)
        {
            s = s.Trim();
            if (string.IsNullOrEmpty(s))
            {
                return false;
            }
            if (s.Contains(' '))
            {
                return false;
            }
            if (!JeNumericko(s))
            {
                return false;
            }
            if (s.Length != 9)
            {
                return false;
            }
            return true;
        }

        public static bool ValidanJmbg(string s)
        {
            s = s.Trim();
            if (string.IsNullOrEmpty(s))
            {
                return false;
            }
            if (s.Contains(' '))
            {
                return false;
            }
            if (!JeNumericko(s))
            {
                return false;
            }
            if (s.Length != 13)
            {
                return false;
            }
            if (DatumRodjenjaPoJmbg(s) is null)
            {
                return false;
            }
            return true;
        }

        public static bool ValidanDatumUlaskaIIzlaska(DateOnly ulazak, DateOnly izlazak)
        {
            if (ulazak > izlazak)
            {
                return false;
            }
            DateOnly sad = DateOnly.FromDateTime(DateTime.Now);
            if (ulazak < sad)
            {
                return false;
            }
            if (izlazak.DayNumber - ulazak.DayNumber + 1 > 90)
            {
                return false;
            }
            return true;
        }

        public static bool ValidanUsernamePassword(string s)
        {
            string patern = @"^[a-zA-Z0-9_]+$";
            return Regex.IsMatch(s, patern);
        }

        public static bool ValidanEmail(string s)
        {
            string patern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(s, patern);
        }

        public static bool PrijavaSeSudaraSaPostojecim(Prijava prijava, List<Prijava> prijave)
        {
            List<Prijava> prijaveSaDrzavama = prijave.FindAll(p =>
            {
                if (p.Drzave is null) return false;
                return p.Drzave.Intersect(prijava.Drzave).Any();
            });
            foreach (var p in prijaveSaDrzavama)
            {
                if (PrijaveSeVremenskiPreklapaju(p, prijava))
                {
                    return true;
                }
            }
            return false;
        }
        
        public static DateOnly? DatumRodjenjaPoJmbg(string jmbg)
        {
            int dan = int.Parse(jmbg.Substring(0, 2));
            int mesec = int.Parse(jmbg.Substring(2, 2));
            int godina = int.Parse(jmbg.Substring(4, 3));
            char c = jmbg[4];
            if (c == '9')
            {
                godina += 1000;
            }
            else
            {
                godina += 2000;
            }
            try
            {
                DateOnly datumRodjenja = new DateOnly(godina, mesec, dan);
                return datumRodjenja;
            }
            catch
            {
                return null;
            }
        }
        
        private static bool PrijaveSeVremenskiPreklapaju(Prijava p1, Prijava p2)
        {
            DateOnly ulazak1 = p1.DatumUlaska, izlazak1 = p1.DatumIzlaska;
            DateOnly ulazak2 = p2.DatumUlaska, izlazak2 = p2.DatumIzlaska;
            if (ulazak1 > izlazak2 || ulazak2 > izlazak1)
            {
                return false;
            }
            return true;
        }
    }
}
