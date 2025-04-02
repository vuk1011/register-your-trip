using Domen;

namespace Testiranje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<DrzavaEU> l1 = new List<DrzavaEU>();
            l1.Add(new DrzavaEU { Naziv = "a" });
            l1.Add(new DrzavaEU { Naziv = "b" });
            
            List<DrzavaEU> l2 = new List<DrzavaEU>();
            l2.Add(new DrzavaEU { Naziv = "b" });
            l2.Add(new DrzavaEU { Naziv = "a" });

            
        }
    }
}
