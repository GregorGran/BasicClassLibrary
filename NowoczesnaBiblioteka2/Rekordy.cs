using Biblioteka;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka;
    public class NiezmiennaOsoba
    {
        public string? Imie { get; init; }
        public string? Nazwisko { get; init; }
    }
public record NiezmienyPojazd
{
    public int Kola { get; init; }
    public string? Kolor { get; init; }
    public string? Marka { get; init; }
}

public record NiezmienneZwierze
{
    public string Nazwa { get; init; }
    public string Gatunek { get; init; }
    public NiezmienneZwierze(string nazwa, string gatunek)
    {
        Nazwa = nazwa;
        Gatunek = gatunek;
    }
    public void Deconstruct(out string nazwa, out string gatunek)
    {
        nazwa = Nazwa;
        gatunek = Gatunek;
    }
}
public record NiezmienneZwierze2(string Nazwa, string gatunek);