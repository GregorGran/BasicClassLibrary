using Biblioteka;
using static System.Console;
using System;


Osoba o1 = new();
WriteLine(o1.ToString());
o1.Nazwisko = "Adam Aniedam";
o1.DataUrodzenia = new System.DateTime(1945, 12, 22);
WriteLine(format: $"{o1.Nazwisko} urodził się w {o1.DataUrodzenia:dddd, d MMMM yyyy}",
    arg0: o1.Nazwisko,
    arg1: o1.DataUrodzenia);

Osoba o2 = new();
{
   o2.Nazwisko = "Alicja Czarów";
   o2.DataUrodzenia = new DateTime(1998, 3, 17);
}
WriteLine(format: $"{o2.Nazwisko} urodziła się {o2.DataUrodzenia:d MMM yy}");

o1.UlubionyCud = AntyczneCudaSwiata.KolosRodyjski;
WriteLine(format: $"Ulubiony cud {o1.Nazwisko} to {o1.UlubionyCud}. Jego numer w kolejności to {(int)o1.UlubionyCud}");
o1.DoOdwiedzenia = AntyczneCudaSwiata.WiszaceOgrody | AntyczneCudaSwiata.MauzoleumWHalikarnasie;
WriteLine($"{o1.Nazwisko} chce odwiedzić {o1.DoOdwiedzenia}");
o1.Dzieci.Add(new Osoba { Nazwisko = "Juanita" });
o1.Dzieci.Add(new() { Nazwisko = "Rolland" });
WriteLine($"{o1.Nazwisko} ma {o1.Dzieci.Count} dzieci");
for (int dziecko = 0; dziecko < o1.Dzieci.Count; dziecko++)
{
    WriteLine($"{o1.Dzieci[dziecko].Nazwisko}");
}
KontoBankowe.Oprocentowanie = 0.12M;
KontoBankowe kb1 = new();
kb1.NazwaKonta = "Pani Rekobery";
kb1.Saldo = 2400;
WriteLine(format: $"{kb1.NazwaKonta} zarobiła {kb1.Saldo * KontoBankowe.Oprocentowanie} na odsetkach");

KontoBankowe kb2 = new();
kb2.NazwaKonta = "Pan Retlemajer";
kb2.Saldo = 6000000;
WriteLine(format: $"{kb2.NazwaKonta} zarobiła {kb2.Saldo * KontoBankowe.Oprocentowanie} na odsetkach");

WriteLine($"{o1.Nazwisko} to {Osoba.Gatunek}");

WriteLine($"{o1.Nazwisko} pochodzi z planety {o1.Planeta}");

Osoba o3 = new();
WriteLine(format: $"{o3.Nazwisko} z planety {o3.Planeta}, utworzono o godzinie {o3.Utworzono:hh:mm:ss} w dniu {o3.Utworzono:dddd}");

var o4 = new Osoba("Artur", "Saturn");
WriteLine(format: $"{o4.Nazwisko} z planety {o4.Planeta} utworzono o godzinie {o4.Utworzono:hh:mm:ss} w dniu {o4.Utworzono:dddd}");

o1.WypiszWkonsoli();
    WriteLine(o1.PodajPochodzenie());

(string, int) owoc = o1.WezOwoce();
WriteLine($"{owoc.Item1}, jest ich {owoc.Item2}");

var nazwanyOwoc = o1.PobierzNazwaneOwoce();
WriteLine($"Czy masz {nazwanyOwoc.Liczba} {nazwanyOwoc.Nazwa}?");

var krotka1 = ("Mateusz", 4);
WriteLine($"{krotka1.Item1} ma {krotka1.Item2} dzieci");

var krotka2 = (o1.Nazwisko, o1.Dzieci.Count);
WriteLine($"{krotka2.Nazwisko} ma {krotka2.Count} dzieci.");

(string nazwaOwocu, int liczbaOwocow) = o1.WezOwoce();
WriteLine($"Po dekonstrukcji: {nazwaOwocu}, {liczbaOwocow} ");

var (nazwisko1, dataUrodzenia1) = o1;
WriteLine($"Po dekonstrukcji: {nazwisko1}, {dataUrodzenia1}");
var (nazwisko2, dataUrodzenia2, ulubiony2) = o1;
WriteLine($"Po dekonstrukcji: {nazwisko2}, {dataUrodzenia2}, {ulubiony2} ");

WriteLine(o1.PowiedzCzesc());
WriteLine(o1.PowiedzCzesc("Emikia"));

WriteLine(o1.ParametryOpcjonalne());

WriteLine(o1.ParametryOpcjonalne("Skacz!", 32));

WriteLine(o1.ParametryOpcjonalne(liczba: 52.7, polecenie: "kryć sie!"));

WriteLine(o1.ParametryOpcjonalne("siadaj", aktywne: false));

int a = 10;
int b = 20;
int c = 30;

WriteLine($"przed: a = {a}, b = {b}, c = {c}");
o1.PrzekazywanieParametrow(a, ref b, ref c);
WriteLine($"Po: a = {a}, b = {b}, c = {c}");

int d = 10;
int e = 20;
int f = 30;
WriteLine($"przed: d= {d}, e = {e}, f jeszcze nie istnieje!");
// o1.PrzekazywanieParametrow(d, ref e, out var f); out nie działa do ogarnięcia
WriteLine($"Po: d = {d}, e = {e}, f = {f}");

Osoba staszek = new()
{
    Nazwisko = "Grzegorz",
    DataUrodzenia = new DateTime(1998, 12, 20)
};
WriteLine(staszek.Pochodzenie);
WriteLine(staszek.Pozdrowienie);
WriteLine(staszek.Wiek);

staszek.UlubioneLody = "czekoladowe";
WriteLine($"Stanisław najchętniej je lody {staszek.UlubioneLody}.");
staszek.UlubionyKolorPodstawowy = "czerwony";
WriteLine($"Stanisław najbardziej lubi kolor {staszek.UlubionyKolorPodstawowy}.");

staszek.Dzieci.Add(new Osoba { Nazwisko = "Karol" });
staszek.Dzieci.Add(new Osoba { Nazwisko = "Marotas" });

WriteLine($"Pierwsze dziecko Stanisława to {staszek.Dzieci[0].Nazwisko}");
WriteLine($"Pierwsze dziecko Stanisława to {staszek.Dzieci[1].Nazwisko}");

WriteLine($"Pierwsze dziecko Stanisława to {staszek[0].Nazwisko}");
WriteLine($"Pierwsze dziecko Stanisława to {staszek[1].Nazwisko}");

object[] pasazerowie = {
new PasazerKlasyPierwszej { mile = 1344 },
new PasazerKlasyPierwszej { mile = 543 },
new PasazerKlasyBiznesowej (),
new PasazerKlasyEkonomicznej { BagazPodreczny = 24.7 },
new PasazerKlasyEkonomicznej { BagazPodreczny = 10 },
};

foreach (object pasazer in pasazerowie)
{
    decimal kosztPrzelotu = pasazer switch
    {
        PasazerKlasyPierwszej p when p.mile > 35000 => 1500M,
        PasazerKlasyPierwszej p when p.mile > 15000 => 1750M,
        PasazerKlasyPierwszej _ => 2000M,
        PasazerKlasyBiznesowej _ => 1000M,
        PasazerKlasyEkonomicznej p when p.BagazPodreczny < 10.0 => 500M,
        PasazerKlasyEkonomicznej _ => 650M,
        _ => 800M
    };
    WriteLine($"Lot pasażera {pasazer} kosztuje {kosztPrzelotu}");

}

NiezmiennaOsoba jurek = new()
{
    Imie = "Jurek",
    Nazwisko = " Marynarz"
};

//jurek.Imie = "Grzgorz";

NiezmienyPojazd samochod = new()
{
    Marka = "Mazda RX-8",
    Kolor = "Sky blue Matallic",
    Kola = 5
};

NiezmienyPojazd przemalowanySamochod = samochod
    with
{ Kolor = "Green grass Matt" };
WriteLine($"Pierwotnie auto miało kolor {samochod.Kolor}.");
WriteLine($"A teraz ma kolor {przemalowanySamochod.Kolor}");

NiezmienneZwierze oskar = new("oskar", "Labrador");
var (kto, co) = oskar; // wywołuje metode deconstruct
WriteLine($"{kto} to {co}");

NiezmienneZwierze2 romuald = new("romuald", "Pitbull");
var (kto2, co2) = romuald; // wywołuje metode deconstruct
WriteLine($"{kto2} to {co2}");