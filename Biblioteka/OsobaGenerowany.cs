using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    public partial class Osoba
    {
        public string Pochodzenie
        {
            get
            {
                return $"{Nazwisko} pochodzi z planety {Planeta}";
            }
        }
        public string Pozdrowienie => $"{Nazwisko} mówi 'cześć'";
        public int Wiek => System.DateTime.Today.Year - DataUrodzenia.Year;
        public  string UlubioneLody { get; set; }

        private string ulubionyKolorPodstawowy;

        public string UlubionyKolorPodstawowy
        {
            get
            {
                return ulubionyKolorPodstawowy;
            }
            set
            {
                switch (value.ToLower())
                {
                    case "czerwony":
                    case "zielony":
                    case "niebieski":
                        ulubionyKolorPodstawowy= value;
                        break;
                    default:
                        throw new System.ArgumentException($"{value} nie jest kolorem podstawowym. Wybieraj spośród wartości: czerwony, zielony, niebieski.");
                }
            }
        }
        public Osoba this[int indeks]
        {
            get { return Dzieci[indeks]; }
            set { Dzieci[indeks] = value; }
        }

    }
}
