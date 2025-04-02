using AplikacijaKlijent.KontrolerKI;
using AplikacijaKlijent.Utils;
using Domen;

namespace AplikacijaKlijent.UserControls
{
    public partial class UCRegistracijaKorisnika : UserControl
    {
        public UCRegistracijaKorisnika()
        {
            InitializeComponent();

            ToolTip tipUsername = new ToolTip();
            tipUsername.SetToolTip(labelUsername, "Кориснико име мора садржати до 50 карактера. Дозвољена су слова енглеског алфабета, цифре, као и доња црта.");
            ToolTip tipPassword = new ToolTip();
            tipPassword.SetToolTip(labelPassword, "Шифра мора садржати до 50 карактера. Дозвољена су слова енглеског алфабета, цифре, као и доња црта.");

            buttonRegistracija.Click += ButtonRegistracija_Click;
        }

        private void ButtonRegistracija_Click(object? sender, EventArgs e)
        {
            // Validacija input polja
            string ime = textBoxIme.Text.Trim();
            string prezime = textBoxPrezime.Text.Trim();
            string jmbg = textBoxJmbg.Text.Trim();
            string pasos = textBoxBrPasosa.Text.Trim();
            string email = textBoxEmail.Text.Trim();
            string user = textBoxUsername.Text;
            string pass = textBoxPassword.Text;

            if (string.IsNullOrEmpty(ime))
            {
                Validator.PrikaziGresku("Нисте унели сва поља.");
                return;
            }
            if (string.IsNullOrEmpty(prezime))
            {
                Validator.PrikaziGresku("Нисте унели сва поља.");
                return;
            }
            if (string.IsNullOrEmpty(jmbg))
            {
                Validator.PrikaziGresku("Нисте унели сва поља.");
                return;
            }
            if (string.IsNullOrEmpty(pasos))
            {
                Validator.PrikaziGresku("Нисте унели сва поља.");
                return;
            }
            if (string.IsNullOrEmpty(email))
            {
                Validator.PrikaziGresku("Нисте унели сва поља.");
                return;
            }
            if (string.IsNullOrEmpty(user))
            {
                Validator.PrikaziGresku("Нисте унели сва поља.");
                return;
            }
            if (string.IsNullOrEmpty(pass))
            {
                Validator.PrikaziGresku("Нисте унели сва поља.");
                return;
            }

            if (!Validator.ValidnoIme(ime))
            {
                Validator.PrikaziGresku("Погрешно унето име.");
                return;
            }
            if (!Validator.ValidnoIme(prezime))
            {
                Validator.PrikaziGresku("Погрешно унето презиме.");
                return;
            }
            if (!Validator.ValidanJmbg(jmbg))
            {
                Validator.PrikaziGresku("Погрешно унет ЈМБГ.");
                return;
            }
            if (!Validator.ValidanBrPasosa(pasos))
            {
                Validator.PrikaziGresku("Погрешно унет број пасоша.");
                return;
            }
            if (!Validator.ValidanEmail(email))
            {
                Validator.PrikaziGresku("Погрешно унет е-маил.");
                return;
            }
            if (!Validator.ValidanUsernamePassword(user))
            {
                Validator.PrikaziGresku("Погрешно унето корисничко име.");
                return;
            }
            if (!Validator.ValidanUsernamePassword(pass))
            {
                Validator.PrikaziGresku("Погрешно унета шифра.");
                return;
            }

            // Provera postojanja stanovnika
            Stanovnik stanovnik = new Stanovnik
            {
                Ime = ime,
                Prezime = prezime,
                Jmbg = jmbg,
                BrojPasosa = pasos,
            };
            try
            {
                if (!Kontroler.Instanca.PostojiStanovnik(stanovnik))
                {
                    Validator.PrikaziGresku("Неисправни лични подаци.");
                    return;
                }
            }
            catch (Exception ex)
            {
                Validator.PrikaziGresku(ex.Message);
                return;
            }

            // Provera da li osoba vec ima nalog
            try
            {
                if (Kontroler.Instanca.PostojiKorisnikZaStanovnika(stanovnik))
                {
                    Validator.PrikaziGresku("Већ постоји регистрован корисник за ове личне податке.");
                    return;
                }
            }
            catch (Exception ex)
            {
                Validator.PrikaziGresku(ex.Message);
                return;
            }

            // Provera da li je username dostupan
            try
            {
                if (Kontroler.Instanca.PostojiKorisnikSaUsername(user))
                {
                    Validator.PrikaziGresku("Ово корисничко име је већ у употреби.");
                    return;
                }
            }
            catch (Exception ex)
            {
                Validator.PrikaziGresku(ex.Message);
                return;
            }

            // Kreiranje korisnika
            try
            {
                Kontroler.Instanca.DodajKorisnika(new Korisnik
                {
                    Ime = ime,
                    Prezime = prezime,
                    Jmbg = jmbg,
                    BrojPasosa = pasos,
                    Email = email,
                    Username = user,
                    Password = pass,
                });
                Validator.PrikaziUspesno("Креиран је кориснички налог, сада се можете пријавити.");
                Enabled = false;
            }
            catch (Exception ex)
            {
                Validator.PrikaziGresku(ex.Message);
                return;
            }
        }
    }
}
