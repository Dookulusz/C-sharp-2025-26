void Feladat(int sorszam = 1, string uzenet = "Feldadat")
{
    Console.Clear();
    Console.WriteLine($"{sorszam}. {uzenet}");
    Console.WriteLine();
    Console.ReadKey();
}

void Nev(string vezetek, string kozepso, string utonev = "")
{
    Console.WriteLine($"Üdv, {vezetek} {kozepso} {utonev}!");
}

var egyik = "Dóka";
var másik = "Dániel";

Nev("Dóka", "Dániel");
Nev(egyik, másik);
Nev("Dóka", "Dániel", "kuvait");

Feladat();
Feladat(2, "Lecke");
Feladat(3, "Tananyag");

string kerdes = "Mi a neved?";
string valasz = ReadNotEmptyString(kerdes);

string ReadNotEmptyString(string kerdes)
{
    valasz = string.Empty;

    while (valasz == string.Empty)
    {
        Console.Write(kerdes);
        valasz = Console.ReadLine();
    }

    return valasz;
}

valasz = ReadNotEmptyString(kerdes);




