using Domen;

namespace AplikacijaKlijent.Utils
{
    internal class FajlGenerator
    {
        public static void UpisiPrijavuUFajl(Prijava p)
        {
            string tekst = FajlTekst(p);
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Text Files (*.txt)|*.txt";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(dialog.FileName, tekst);
                Validator.PrikaziUspesno("Генерисана је датотека са подацима о пријави.");
            }
        }

        private static string FajlTekst(Prijava p)
        {
            string s = "";
            s += "ПРИЈАВА ПУТОВАЊА ЗА ЕУ\n";
            s += "_______________________________\n";
            s += $"Име.............{p.Ime}\n";
            s += $"Презиме.........{p.Prezime}\n";
            s += $"ЈМБГ............{p.Jmbg}\n";
            s += $"Број пасоша.....{p.BrojPasosa}\n";
            s += $"Датум уласка....{p.DatumUlaska}\n";
            s += $"Датум изласка...{p.DatumIzlaska}\n";
            s += "Држава/е........";
            foreach (var d in p.Drzave)
            {
                s += d.Naziv + ", ";
            }
            s = s.Substring(0, s.Length - 2);
            s += "\n";
            s += $"Број дана.......{p.DaniZadrzavanja}\n";
            s += "_______________________________\n";
            s += "*Потребно платити: ";
            s += p.TrebaPlatiti ? "ДА\n" : "НЕ\n";

            return s;
        }
    }
}
