using AplikacijaKlijent.KontrolerKI;
using AplikacijaKlijent.Utils;
using Domen;
using System.ComponentModel;

namespace AplikacijaKlijent.UserControls
{
    public partial class UCPregledIIzmenaPrijava : UserControl
    {
        private Korisnik? korisnik;
        private BindingList<Prijava> prijave;

        public UCPregledIIzmenaPrijava(Korisnik? korisnik)
        {
            this.korisnik = korisnik;
            prijave = new BindingList<Prijava>();

            InitializeComponent();

            if (korisnik != null)
            {
                panelUnosJmbgPasos.Enabled = false;
                UcitajPrijaveUlogovanogKorisnika();
            }

            buttonIzmenaPrijave.Enabled = false;
            buttonBrisanjePrijave.Enabled = false;
            buttonGenerisanjePotvrde.Enabled = false;

            dataGridViewPrijave.DataSource = prijave;
            dataGridViewPrijave.Columns["Id"].Visible = false;
            dataGridViewPrijave.Columns["Jmbg"].Visible = false;
            dataGridViewPrijave.Columns["BrojPasosa"].Visible = false;
            dataGridViewPrijave.Columns["Ime"].Visible = false;
            dataGridViewPrijave.Columns["Prezime"].Visible = false;
            dataGridViewPrijave.Columns["DatumUlaska"].HeaderText = "Датум уласка";
            dataGridViewPrijave.Columns["DatumIzlaska"].HeaderText = "Датум изласка";
            dataGridViewPrijave.Columns["NacinPrevoza"].HeaderText = "Начин превоза";
            dataGridViewPrijave.Columns["TrebaPlatiti"].HeaderText = "Треба платити";
            dataGridViewPrijave.Columns["DaniZadrzavanja"].HeaderText = "Дани задржавања";
            dataGridViewPrijave.Columns["Status"].HeaderText = "Статус пријаве";
            dataGridViewPrijave.Columns["DrzaveDisplay"].HeaderText = "Државе";


            dataGridViewPrijave.SelectionChanged += DataGridViewPrijave_SelectionChanged;
            buttonPogledajPrijave.Click += ButtonPogledajPrijave_Click;
            buttonGenerisanjePotvrde.Click += ButtonGenerisanjePotvrde_Click;
            buttonBrisanjePrijave.Click += ButtonBrisanjePrijave_Click;
            buttonIzmenaPrijave.Click += ButtonIzmenaPrijave_Click;
        }

        private bool Ulogovan()
        {
            return korisnik is not null;
        }

        public void UcitajPrijaveUlogovanogKorisnika()
        {
            if (!Ulogovan()) return;
            try
            {
                List<Prijava> prijaveKorisnika = Kontroler.Instanca.VratiPrijave(korisnik.Jmbg);
                if (prijaveKorisnika.Count > 0)
                {
                    prijave = new BindingList<Prijava>(prijaveKorisnika);
                }
                dataGridViewPrijave.DataSource = prijave;
                dataGridViewPrijave.CurrentCell = null;
            }
            catch (Exception ex)
            {
                Enabled = false;
                Validator.PrikaziGresku(ex.Message);
            }
        }

        private void FormIzmenaPrijave_IzmenjenaPrijava(object? sender, EventArgs e)
        {
            UcitajPrijaveUlogovanogKorisnika();
        }

        private void ButtonIzmenaPrijave_Click(object? sender, EventArgs e)
        {
            Prijava prijava = (Prijava)dataGridViewPrijave.CurrentRow.DataBoundItem;
            if (prijava is not null)
            {
                List<Prijava> prijaveBezIzabranePrijave = prijave.ToList();
                prijaveBezIzabranePrijave.Remove(prijava);
                FormIzmenaPrijave formaIzmena = new FormIzmenaPrijave(korisnik, prijava, prijaveBezIzabranePrijave);
                formaIzmena.IzmenjenaPrijava += FormIzmenaPrijave_IzmenjenaPrijava;
                try
                {
                    formaIzmena.ShowDialog();
                }
                catch (Exception) { }
            }
        }

        private void ButtonBrisanjePrijave_Click(object? sender, EventArgs e)
        {
            var result = MessageBox.Show("Да ли сигурно желите да избришете ову пријаву?", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Prijava p = (Prijava)dataGridViewPrijave.CurrentRow.DataBoundItem;
                try
                {
                    Kontroler.Instanca.ObrisiPrijavu(p);
                    Validator.PrikaziUspesno("Пријава је успешно обрисана.");
                    prijave.Remove(p);
                }
                catch (Exception ex)
                {
                    Validator.PrikaziGresku(ex.Message);
                }
            }
        }

        private void ButtonGenerisanjePotvrde_Click(object? sender, EventArgs e)
        {
            Prijava prijava = (Prijava)dataGridViewPrijave.CurrentRow.DataBoundItem;
            FajlGenerator.UpisiPrijavuUFajl(prijava);
        }

        private void DataGridViewPrijave_SelectionChanged(object? sender, EventArgs e)
        {
            var selected = dataGridViewPrijave.CurrentRow;
            if (selected == null)
            {
                buttonIzmenaPrijave.Enabled = false;
                buttonBrisanjePrijave.Enabled = false;
                buttonGenerisanjePotvrde.Enabled = false;
                return;
            }
            Prijava prijava = (Prijava)selected.DataBoundItem;
            switch (prijava.Status)
            {
                case StatusPrijave.UObradi:
                    buttonIzmenaPrijave.Enabled = (korisnik != null);
                    buttonBrisanjePrijave.Enabled = (korisnik != null);
                    buttonGenerisanjePotvrde.Enabled = true;
                    break;
                case StatusPrijave.Zakljucana:
                    buttonIzmenaPrijave.Enabled = false;
                    buttonBrisanjePrijave.Enabled = false;
                    buttonGenerisanjePotvrde.Enabled = true;
                    break;
                case StatusPrijave.Zavrsena:
                    buttonIzmenaPrijave.Enabled = false;
                    buttonBrisanjePrijave.Enabled = false;
                    buttonGenerisanjePotvrde.Enabled = false;
                    break;
            }
        }

        private void ButtonPogledajPrijave_Click(object? sender, EventArgs e)
        {
            // Validacija input polja
            if (!Validator.ValidanJmbg(textBoxJmbg.Text))
            {
                Validator.PrikaziGresku("Погрешно унет ЈМБГ.");
                return;
            }
            if (!Validator.ValidanBrPasosa(textBoxBrPasosa.Text))
            {
                Validator.PrikaziGresku("Погрешно унет број пасоша.");
                return;
            }

            // Provera postojanja stanovnika
            Stanovnik stanovnik = new Stanovnik
            {
                Jmbg = textBoxJmbg.Text.Trim(),
                BrojPasosa = textBoxBrPasosa.Text.Trim()
            };
            try
            {
                if (!Kontroler.Instanca.PostojiStanovnikSaJmbgIBrojPasosa(stanovnik))
                {
                    Validator.PrikaziGresku("Не постоји особа са унетим подацима.");
                    return;
                }
            }
            catch (Exception ex)
            {
                Validator.PrikaziGresku(ex.Message);
                return;
            }

            // Ucitavanje prijava
            try
            {
                prijave = new BindingList<Prijava>(Kontroler.Instanca.VratiPrijave(textBoxJmbg.Text.Trim()));
                dataGridViewPrijave.DataSource = prijave;
                dataGridViewPrijave.CurrentCell = null;
            }
            catch (Exception ex)
            {
                Validator.PrikaziGresku(ex.Message);
                return;
            }
        }
    }
}
