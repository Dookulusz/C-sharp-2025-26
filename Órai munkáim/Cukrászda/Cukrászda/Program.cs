using System.Security.Cryptography;
using System.Xml;

var sorok = File.ReadAllLines("forras.txt");

List<Suti> etlap = [];

Suti ajanlat = NapiAjanlat(etlap);
Console.WriteLine("Napi ajalnat:");
Console.WriteLine(ajanlat.Nev);
string keresett = "vegyes";

Console.WriteLine($"A sütemények összára: {Osszar(etlap, keresett)} Ft");



int darab = Megszamol(etlap);

Console.WriteLine($"Díjazottak száma");
Console.WriteLine(darab);

Suti NapiAjanlat(List<Suti> etlap)
{
    Random random = new();
    //véletlen  index
    int index = random.Next(0, etlap.Count);

    //indexeljük meg a listát
    Suti valasztott = etlap[index];

    return valasztott;
}
int Osszar(List<Suti> etlap, string keresett)
{
    int osszeg = 0;

    foreach (var item in etlap)
    {
        if (item.Type.ToLower() == keresett)
        {
            osszeg += item.Ar;
        }
    }
    return osszeg;
}
int Megszamol(List<Suti> etlap)
{
    int darab = 0;

    foreach (var item in etlap)
    {
        if (item.Dijazott)
        {
            darab++;
        }
    }

    return darab;
}

Etlap gerbaud = new(sorok);

Console.WriteLine("Napi ajaénat: ");
Console.WriteLine(gerbaud.Napiajanlat());

Console.WriteLine("Vegyes sütik ára: ");
Console.WriteLine(gerbaud.Osszar("vegyes"));

Console.WriteLine("Díjazottak száma: ");
Console.WriteLine(gerbaud.Dijazott());
