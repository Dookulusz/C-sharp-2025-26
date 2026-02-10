// Fájl beolvasás
string[] sorok = File.ReadAllLines("pizzak.csv");

//lista példányosítása
List<Pizza> etlap = [];

// hagyjuk ki az elso sort!
for (int i = 1; i < sorok.Length; i++)
{
    string aktualis = sorok[i];

    //dolgozzuk fel az adatokat
    Pizza peldany = new(aktualis);

    //tároljuk a listában
    etlap.Add(peldany);
}

//Írjuk képrnyőre az étlap tartalmát!
foreach (var item in etlap)
{
    Console.WriteLine(item.Megjelenik());
}

Pizza üres = new();

üres.Nev = "Teszt";
üres.Ar = 100.001;

Pizza egyik = new("Egyik", 1, 1.0, "nincs");
Console.WriteLine(egyik.Megjelenik());

Pizza masik = new("Masik;2;2,0;cickanyteszta");
Console.WriteLine(masik.Megjelenik());

//Készítsünk inkább egy szöveges listát
//és abban tárojuk a szöveges alakját
//írjuk étlap.txt fájla a File.WriteAlllines() paranccsal!

List<string> export = [];

//Járjuk be az összes pizzát az étlapon
foreach (Pizza item in etlap)
{
    //végezzünk velük valamilyen számítást
    string szovegesen = item.Megjelenik();
    //tároljuk az eredményt szöveges formában
    export.Add(szovegesen);
}

File.WriteAllLines("etlap.txt", export);

// Osztálykészítés
class Pizza
{
    //nyílvános mező
    public string Nev;
    public int Meret;
    public double Ar;
    public string Feltetek;

    //üres konstruktor
    public Pizza()
    {

    }

    // forráskód generálása konstruktorral készíthetünk
    public Pizza(string nev, int meret, double ar, string feltetek)
    {
        Nev = nev;
        Meret = meret;
        Ar = ar;
        Feltetek = feltetek;
    }

    //tetszőleges számú konstruktor készíthtünk
    public Pizza(string sor)
    {
        // "Margerita;32;6;50;paradicsomszor, mozzarella"
        string[] darabok = sor.Split(';');

        //["Margerita", "32", "6.50", "paradicsomszosz, mozzarella"]

        Nev  = darabok[0];
        Meret = int.Parse(darabok[1]);
        Ar = double.Parse(darabok[2]);
        Feltetek = darabok[3];
    }

    //Működést leíró metódusok
    public string Megjelenik()
    {
        return $"{Meret} cm {Nev} {Ar} Euro";
    }
}