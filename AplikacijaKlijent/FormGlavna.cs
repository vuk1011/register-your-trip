using AplikacijaKlijent.KontrolerKI;
using AplikacijaKlijent.UserControls;
using AplikacijaKlijent.Utils;
using Domen;

namespace AplikacijaKlijent
{
    public partial class FormGlavna : Form
    {
        private Korisnik? korisnik;
        private Kontroler kontroler;

        public FormGlavna()
        {
            kontroler = Kontroler.Instanca;

            InitializeComponent();
            PostaviMeniOpcije();
            PoveziSeSaServerom();

            labelPrijavljenKorisnik.Text = "";

            FormClosing += ZatvoriKonekciju;
            meniStavkaPrijavaPutovanja.Click += OtvoriPrijavuPutovanja;
            meniStavkaPregledIIzmena.Click += OtvoriPregledIIzmenuPrijava;
            meniStavkaPrijavaKorisnika.Click += OtvoriPrijavuKorisnika;
            meniStavkaRegistracija.Click += OtvoriRegistracijuKorisnika;
            meniStavkaOdjava.Click += OdjaviKorisnika;
        }

        private void PoveziSeSaServerom()
        {
            try
            {
                kontroler.PoveziSe();
                Validator.PrikaziUspesno("Успостављена веза са сервером.");
            }
            catch (Exception ex)
            {
                Enabled = false;
                Thread.Sleep(2000);
                Validator.PrikaziGresku(ex.Message);
            }
        }

        private void ZatvoriKonekciju(object sender, EventArgs e)
        {
            kontroler.Zatvori();
        }

        private bool Ulogovan()
        {
            return korisnik is not null;
        }

        private void PostaviMeniOpcije()
        {
            if (!Ulogovan())
            {
                meniStavkaPrijavaKorisnika.Visible = true;
                meniStavkaRegistracija.Visible = true;
                meniStavkaOdjava.Visible = false;
            }
            else
            {
                meniStavkaPrijavaKorisnika.Visible = false;
                meniStavkaRegistracija.Visible = false;
                meniStavkaOdjava.Visible = true;
            }
        }

        private void OtvoriPrijavuPutovanja(object sender, EventArgs e)
        {
            panelDesni.Controls.Clear();
            var uc = new UCPrijavaPutovanja(korisnik);
            panelDesni.Controls.Add(uc);
        }

        private void OtvoriPregledIIzmenuPrijava(object sender, EventArgs e)
        {
            panelDesni.Controls.Clear();
            var uc = new UCPregledIIzmenaPrijava(korisnik);
            panelDesni.Controls.Add(uc);
        }

        private void OtvoriPrijavuKorisnika(object sender, EventArgs e)
        {
            panelDesni.Controls.Clear();
            FormPrijavaKorisnika f = new FormPrijavaKorisnika();
            f.PrijavljenKorisnik += FormPrijavaKorisnika_PrijavljenKorisnik;
            try
            {
                f.ShowDialog();
            }
            catch (Exception) { }
        }

        private void FormPrijavaKorisnika_PrijavljenKorisnik(object? sender, Utils.PrijavljenKorisnikEventArgs e)
        {
            korisnik = e.Korisnik;
            PostaviMeniOpcije();
            PozdraviKorisnika();
        }

        private void OtvoriRegistracijuKorisnika(object sender, EventArgs e)
        {
            panelDesni.Controls.Clear();
            var uc = new UCRegistracijaKorisnika();
            panelDesni.Controls.Add(uc);
        }

        private void OdjaviKorisnika(object sender, EventArgs e)
        {
            korisnik = null;
            Visible = false;
            Thread.Sleep(800);
            panelDesni.Controls.Clear();
            PostaviMeniOpcije();
            labelPrijavljenKorisnik.Text = "";
            Visible = true;
        }

        private void PozdraviKorisnika()
        {
            labelPrijavljenKorisnik.Text = $"пријављени сте као корисник [{korisnik.Username}]";
        }
    }
}
