namespace Domen
{
    public class DrzavaEU
    {
        public string Naziv { get; set; }
        public string Kod { get; set; }

        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            if (obj is not DrzavaEU) return false;
            DrzavaEU d = (DrzavaEU)obj;
            return Naziv.Equals(d.Naziv);
        }

        public override int GetHashCode()
        {
            return Naziv != null ? Naziv.GetHashCode() : 0;
        }
    }
}
