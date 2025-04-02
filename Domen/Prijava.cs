namespace Domen
{
    public class Prijava
    {
        public long Id { get; set; }
        public string? Jmbg { get; set; }
        public string? BrojPasosa { get; set; }
        public string? Ime { get; set; }
        public string? Prezime { get; set; }
        public string DrzaveDisplay
        {
            get
            {
                string s = "";
                if (Drzave == null) return s;
                foreach (var d in Drzave)
                {
                    s += d.Kod + ", ";
                }
                s = s.Substring(0, s.Length - 2);
                return s;
            }
        }
        public DateOnly DatumUlaska { get; set; }
        public DateOnly DatumIzlaska { get; set; }
        public NacinPrevoza NacinPrevoza { get; set; }
        public bool TrebaPlatiti { get; set; }
        public List<DrzavaEU>? Drzave { get; set; }
        public int DaniZadrzavanja
        {
            get
            {
                return DatumIzlaska.DayNumber - DatumUlaska.DayNumber + 1;
            }
        }
        public StatusPrijave Status
        {
            get
            {
                var ulazak = DatumUlaska.ToDateTime(new TimeOnly(0, 0, 0));
                var trenutno = DateTime.Now;
                if (trenutno >= ulazak)
                {
                    return StatusPrijave.Zavrsena;
                }
                else if ((ulazak - trenutno).TotalHours < 48)
                {
                    return StatusPrijave.Zakljucana;
                }
                else
                {
                    return StatusPrijave.UObradi;
                }
            }
        }
    }
}
