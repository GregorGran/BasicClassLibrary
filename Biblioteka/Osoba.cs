using System;
using static System.Console;
using System.Collections.Generic;

namespace Biblioteka;


public partial class Osoba : object
{
    public string Nazwisko;
    public DateTime DataUrodzenia;
    public AntyczneCudaSwiata UlubionyCud;
    public AntyczneCudaSwiata DoOdwiedzenia;
    public List<Osoba> Dzieci = new();
    public const string Gatunek = "Homo Sapiens";
    public readonly string Planeta = "wenus";
    public readonly DateTime Utworzono;
    public Osoba()
    {
        Nazwisko = "Nieznane";
        Utworzono = DateTime.Now;
    }
    public Osoba(string wstepneNazwisko, string wstepnaPalanetaPochodzenia)
    {
        Nazwisko = wstepneNazwisko;
        Planeta = wstepnaPalanetaPochodzenia;
        Utworzono = DateTime.Now;
    }
    public void WypiszWkonsoli()
    {
        WriteLine($"{Nazwisko} urodził się w {DataUrodzenia:dddd}");
    }
    public string PodajPochodzenie()
    {
        return $"{Nazwisko} pochodzi z planety {Planeta}";
    }
    public (string, int) WezOwoce()
    {
        return ("Jablka", 5);
    }
    public (string Nazwa, int Liczba) PobierzNazwaneOwoce()
    {
        return (Nazwa: "Jabłka", Liczba: 5);
    }
    public void Deconstruct(out string nazwisko, out DateTime dataUrodzenia)
    {
        nazwisko = Nazwisko;
        dataUrodzenia = DataUrodzenia;
    }
    public void Deconstruct(out string nazwisko, out DateTime dataUrodzenia, out AntyczneCudaSwiata ulubiony)
    {
        nazwisko = Nazwisko;
        dataUrodzenia = DataUrodzenia;
        ulubiony = UlubionyCud;
    }
    public string PowiedzCzesc()
    {
        return $"{Nazwisko} mówi Cześć";
    }
    public string PowiedzCzesc(string imie)
    {
        return $"{Nazwisko} mówi 'Cześć' {imie}";
    }
    public string ParametryOpcjonalne(
        string polecenie = "Biegnij", double liczba = 0.0, bool aktywne = true)
    {
        return string.Format(format: $"polecenie to {polecenie}, liczba to {liczba}, aktywne to {aktywne}");
    }
    public void PrzekazywanieParametrow(int x, ref int y, ref int z)
    {
        z = 99;
        x++;
        y++;
        z++;

    }
}