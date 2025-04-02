using AplikacijaKlijent.KontrolerKI;
using AplikacijaKlijent.Utils;
using Domen;

namespace AplikacijaKlijent
{
    public partial class FormIzmenaPrijave : Form
    {
        private Korisnik korisnik;
        private Prijava prijava;
        private List<Prijava> prijave;
        private List<DrzavaEU> drzave;
        public event EventHandler IzmenjenaPrijava;

        public FormIzmenaPrijave(Korisnik korisnik, Prijava prijava, List<Prijava> prijave)
        {
            this.korisnik = korisnik;
            this.prijava = prijava;
            this.prijave = prijave;

            InitializeComponent();

            try
            {
                drzave = Kontroler.Instanca.VratiDrzavaEU();
                listBoxDrzaveEU.DataSource = drzave;
                listBoxDrzaveEU.DisplayMember = "Naziv";
            }
            catch (Exception ex)
            {
                Validator.PrikaziGresku(ex.Message);
                Close();
            }
            comboBoxNacinPrevoza.DataSource = NacinPrevozaUtil.NaciniPrevoza;

            listBoxDrzaveEU.SelectedIndex = -1;
            int i = 0;
            foreach (DrzavaEU d in drzave)
            {
                if (prijava.Drzave.Contains(d))
                {
                    listBoxDrzaveEU.SetSelected(i, true);
                }
                i++;
            }

            dateTimePickerDatumUlaska.Value = prijava.DatumUlaska.ToDateTime(new TimeOnly(0, 0, 0));
            dateTimePickerDatumIzlaska.Value = prijava.DatumIzlaska.ToDateTime(new TimeOnly(0, 0, 0));

            comboBoxNacinPrevoza.SelectedItem = prijava.NacinPrevoza;

            dateTimePickerDatumUlaska.ValueChanged += DateTimePickerDatumUlaska_ValueChanged;
            buttonIzmeniPrijavu.Click += ButtonIzmeniPrijavu_Click;
        }

        private void ButtonIzmeniPrijavu_Click(object? sender, EventArgs e)
        {
            Prijava izmenjenaPrijava = new Prijava
            {
                Id = prijava.Id,
                Ime = korisnik.Ime,
                Prezime = korisnik.Prezime,
                Jmbg = korisnik.Jmbg,
                BrojPasosa = korisnik.BrojPasosa,
                NacinPrevoza = (NacinPrevoza)comboBoxNacinPrevoza.SelectedItem,
                DatumUlaska = DateOnly.FromDateTime(dateTimePickerDatumUlaska.Value),
                DatumIzlaska = DateOnly.FromDateTime(dateTimePickerDatumIzlaska.Value),
                Drzave = new List<DrzavaEU>()
            };
            var izabraneDrzave = listBoxDrzaveEU.SelectedItems;
            if (izabraneDrzave.Count == 0)
            {
                Validator.PrikaziGresku("Морате изабрати државу/е.");
                return;
            }
            foreach (var d in izabraneDrzave)
            {
                izmenjenaPrijava.Drzave.Add((DrzavaEU)d);
            }
            DateOnly datumRodjenja = (DateOnly)Validator.DatumRodjenjaPoJmbg(izmenjenaPrijava.Jmbg);
            DateOnly danas = DateOnly.FromDateTime(DateTime.Now);
            int godine = danas.Year - datumRodjenja.Year;
            if (datumRodjenja.AddYears(godine) > danas)
            {
                godine--;
            }
            izmenjenaPrijava.TrebaPlatiti = godine >= 18 && godine <= 70;

            if (!Validator.ValidanDatumUlaskaIIzlaska(izmenjenaPrijava.DatumUlaska, izmenjenaPrijava.DatumIzlaska))
            {
                Validator.PrikaziGresku("Погрешно унет датум.");
                return;
            }
            if (Validator.PrijavaSeSudaraSaPostojecim(izmenjenaPrijava, prijave))
            {
                Validator.PrikaziGresku("Пријава за дати датум и државе није могућа због сударања са Вашим другим пријавама.");
                return;
            }

            try
            {
                Kontroler.Instanca.IzmeniPrijavu(izmenjenaPrijava);
                Validator.PrikaziUspesno("Пријава је измењена.");
                IzmenjenaPrijava?.Invoke(this, EventArgs.Empty);
                Close();
            }
            catch (Exception ex)
            {
                Validator.PrikaziGresku(ex.Message);
                return;
            }
        }

        private void DateTimePickerDatumUlaska_ValueChanged(object? sender, EventArgs e)
        {
            if (dateTimePickerDatumIzlaska.Value < dateTimePickerDatumUlaska.Value)
            {
                dateTimePickerDatumIzlaska.Value = dateTimePickerDatumUlaska.Value;
            }
        }
    }
}
