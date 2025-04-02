using AplikacijaKlijent.KontrolerKI;
using AplikacijaKlijent.Utils;
using Domen;

namespace AplikacijaKlijent.UserControls
{
    public partial class UCPrijavaPutovanja : UserControl
    {
        private Korisnik? korisnik;
        private List<Prijava> prijave;

        public UCPrijavaPutovanja(Korisnik? korisnik)
        {
            this.korisnik = korisnik;
            prijave = new List<Prijava>();

            InitializeComponent();

            dateTimePickerDatumUlaska.MinDate = DateTime.Now.AddDays(3);
            dateTimePickerDatumIzlaska.MinDate = dateTimePickerDatumUlaska.MinDate;
            if (korisnik is not null) panelLicniPodaci.Enabled = false;
            try
            {
                listBoxDrzaveEU.DataSource = Kontroler.Instanca.VratiDrzavaEU();
                listBoxDrzaveEU.DisplayMember = "Naziv";
                listBoxDrzaveEU.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                Enabled = false;
                Thread.Sleep(2000);
                Validator.PrikaziGresku(ex.Message);
            }
            comboBoxNacinPrevoza.DataSource = NacinPrevozaUtil.NaciniPrevoza;

            buttonPodnesiPrijavu.Click += ButtonPodnesiPrijavu_Click;
            dateTimePickerDatumUlaska.ValueChanged += DateTimePickerDatumUlaska_ValueChanged;
        }

        private bool Ulogovan()
        {
            return korisnik is not null;
        }

        private void DateTimePickerDatumUlaska_ValueChanged(object? sender, EventArgs e)
        {
            if (dateTimePickerDatumIzlaska.Value < dateTimePickerDatumUlaska.Value)
            {
                dateTimePickerDatumIzlaska.Value = dateTimePickerDatumUlaska.Value;
            }
        }

        private void ButtonPodnesiPrijavu_Click(object? sender, EventArgs e)
        {
            if (Ulogovan())
            {
                try
                {
                    prijave = Kontroler.Instanca.VratiPrijave(korisnik.Jmbg);
                }
                catch (Exception ex)
                {
                    Validator.PrikaziGresku(ex.Message);
                    return;
                }

                Prijava prijava = new Prijava
                {
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
                    prijava.Drzave.Add((DrzavaEU)d);
                }

                DateOnly datumRodjenja = (DateOnly)Validator.DatumRodjenjaPoJmbg(prijava.Jmbg);
                DateOnly danas = DateOnly.FromDateTime(DateTime.Now);
                int godine = danas.Year - datumRodjenja.Year;
                if (datumRodjenja.AddYears(godine) > danas)
                {
                    godine--;
                }
                prijava.TrebaPlatiti = godine >= 18 && godine <= 70;

                if (!Validator.ValidanDatumUlaskaIIzlaska(prijava.DatumUlaska, prijava.DatumIzlaska))
                {
                    Validator.PrikaziGresku("Погрешно унет датум.");
                    return;
                }
                if (Validator.PrijavaSeSudaraSaPostojecim(prijava, prijave))
                {
                    Validator.PrikaziGresku("Пријава за дати датум и државе није могућа због сударања са Вашим другим пријавама.");
                    return;
                }

                try
                {
                    Kontroler.Instanca.DodajPrijavu(prijava);
                    Validator.PrikaziUspesno("Пријава је додата.");
                }
                catch (Exception ex)
                {
                    Validator.PrikaziGresku(ex.Message);
                    return;
                }

                FajlGenerator.UpisiPrijavuUFajl(prijava);
            }
            else
            {
                if (!Validator.ValidnoIme(textBoxIme.Text))
                {
                    Validator.PrikaziGresku("Погрешно унето име.");
                    return;
                }
                if (!Validator.ValidnoIme(textBoxPrezime.Text))
                {
                    Validator.PrikaziGresku("Погрешно унето презиме.");
                    return;
                }
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

                DateOnly ulaz = DateOnly.FromDateTime(dateTimePickerDatumUlaska.Value);
                DateOnly izlaz = DateOnly.FromDateTime(dateTimePickerDatumIzlaska.Value);
                if (!Validator.ValidanDatumUlaskaIIzlaska(ulaz, izlaz))
                {
                    Validator.PrikaziGresku("Погрешно унет датум.");
                    return;
                }

                if (listBoxDrzaveEU.SelectedItems.Count == 0)
                {
                    Validator.PrikaziGresku("Морате изабрати државу/е.");
                    return;
                }

                Stanovnik stanovnik = new Stanovnik
                {
                    Ime = textBoxIme.Text.Trim(),
                    Prezime = textBoxPrezime.Text.Trim(),
                    Jmbg = textBoxJmbg.Text.Trim(),
                    BrojPasosa = textBoxBrPasosa.Text.Trim()
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

                try
                {
                    prijave = Kontroler.Instanca.VratiPrijave(textBoxJmbg.Text.Trim());
                }
                catch (Exception ex)
                {
                    Validator.PrikaziGresku(ex.Message);
                    return;
                }

                Prijava prijava = new Prijava
                {
                    Ime = textBoxIme.Text.Trim(),
                    Prezime = textBoxPrezime.Text.Trim(),
                    Jmbg = textBoxJmbg.Text.Trim(),
                    BrojPasosa = textBoxBrPasosa.Text.Trim(),
                    NacinPrevoza = (NacinPrevoza)comboBoxNacinPrevoza.SelectedItem,
                    DatumUlaska = DateOnly.FromDateTime(dateTimePickerDatumUlaska.Value),
                    DatumIzlaska = DateOnly.FromDateTime(dateTimePickerDatumIzlaska.Value),
                    Drzave = new List<DrzavaEU>()
                };

                foreach (var d in listBoxDrzaveEU.SelectedItems)
                {
                    prijava.Drzave.Add((DrzavaEU)d);
                }

                DateOnly datumRodjenja = (DateOnly)Validator.DatumRodjenjaPoJmbg(prijava.Jmbg);
                DateOnly danas = DateOnly.FromDateTime(DateTime.Now);
                int godine = danas.Year - datumRodjenja.Year;
                if (datumRodjenja.AddYears(godine) > danas)
                {
                    godine--;
                }
                prijava.TrebaPlatiti = godine >= 18 && godine <= 70;

                if (Validator.PrijavaSeSudaraSaPostojecim(prijava, prijave))
                {
                    Validator.PrikaziGresku("Пријава за дати датум и државе није могућа због сударања са Вашим другим пријавама.");
                    return;
                }

                try
                {
                    Kontroler.Instanca.DodajPrijavu(prijava);
                    Validator.PrikaziUspesno("Пријава је додата.");
                }
                catch (Exception ex)
                {
                    Validator.PrikaziGresku(ex.Message);
                    return;
                }

                FajlGenerator.UpisiPrijavuUFajl(prijava);
            }
        }
    }
}
