using Domen;

namespace AplikacijaKlijent.Utils
{
    internal static class NacinPrevozaUtil
    {
        public static List<NacinPrevoza> NaciniPrevoza
        {
            get
            {
                var lista = new List<NacinPrevoza>();
                lista.Add(NacinPrevoza.PutnickiAutomobil);
                lista.Add(NacinPrevoza.Motocikl);
                lista.Add(NacinPrevoza.Autobus);
                lista.Add(NacinPrevoza.AvioPrevoz);
                return lista;
            }
        }
    }
}
