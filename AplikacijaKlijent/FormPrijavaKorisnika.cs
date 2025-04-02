using AplikacijaKlijent.KontrolerKI;
using AplikacijaKlijent.Utils;
using Domen;

namespace AplikacijaKlijent
{
    public partial class FormPrijavaKorisnika : Form
    {
        public event EventHandler<PrijavljenKorisnikEventArgs>? PrijavljenKorisnik;

        public FormPrijavaKorisnika()
        {
            InitializeComponent();

            buttonPrijaviSe.Click += ButtonPrijaviSe_Click;
        }

        private void ButtonPrijaviSe_Click(object? sender, EventArgs e)
        {
            string user = textBoxUsername.Text;
            string pass = textBoxPassword.Text;

            // Validacija polja

            if (string.IsNullOrEmpty(user))
            {
                Validator.PrikaziGresku("Унесите корисничко име.");
                return;
            }
            if (string.IsNullOrEmpty(pass))
            {
                Validator.PrikaziGresku("Унесите шифру.");
                return;
            }
            if (!Validator.ValidanUsernamePassword(user))
            {
                Validator.PrikaziGresku("Погрешно унето корисничко име и/или шифра.");
                return;
            }
            if (!Validator.ValidanUsernamePassword(pass))
            {
                Validator.PrikaziGresku("Погрешно унето корисничко име и/или шифра.");
                return;
            }

            // Provera postojanja korisnika za username

            try
            {
                if (!Kontroler.Instanca.PostojiKorisnikSaUsername(user))
                {
                    Validator.PrikaziGresku("Погрешно унето корисничко име и/или шифра.");
                    return;
                }
            }
            catch (Exception ex)
            {
                Validator.PrikaziGresku(ex.Message);
                return;
            }

            // Prijava korisnika

            try
            {
                Korisnik korisnik = Kontroler.Instanca.PrijaviKorisnika(new Korisnik { Username = user, Password = pass });
                PrijavljenKorisnik?.Invoke(this, new PrijavljenKorisnikEventArgs(korisnik));
                Close();
            }
            catch (Exception ex)
            {
                Validator.PrikaziGresku(ex.Message);
                return;
            }
        }
    }
}
