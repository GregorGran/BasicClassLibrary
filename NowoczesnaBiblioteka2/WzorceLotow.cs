using System.Transactions;

namespace Biblioteka
{
    public class PasazerKlasyBiznesowej
    {
        public override string ToString()
        {
            return $"Klasa biznesowa";
        }
    }

    public class PasazerKlasyPierwszej
    {
        public int mile { get; set; }
        public override string ToString()
        {
            return $"Klasa pierwsza i {mile} mil";

        }
    }
    public class PasazerKlasyEkonomicznej
    {
        public double BagazPodreczny { get; set; }
        public override string ToString()
        {
            return $"Klasa ekonomiczna z bagażem {BagazPodreczny:N2} kg";
        }
    }
}