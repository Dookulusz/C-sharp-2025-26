//fájl beolvasása
string[] sorok = File.ReadAllLines("pizzak.csv");

Pizza üres = new();

üres.Nev = "Teszt";
üres.Ar = 100.001;

Pizza egyik = new("Egyik", 1, 1.0, "nincs");
Console.WriteLine(egyik.Megjelenit());


Pizza masik = new("Masik", 2, 2.0, "cickanyteszta");
Console.WriteLine(masik.Megjelenit());

List<Pizza> etlap = [];

for (int i = 1; i < sorok.Length; i++)
{
    string aktualis = sorok[i];

    Pizza peldany = new(aktualis);

    etlap.Add(peldany);
}
foreach (var item in etlap)
{
    Console.WriteLine(item.Megjelenit());
}

//osztálykészítés
class Pizza
{
    //nyilvános mezők
    public string Nev;
    public int Meret;
    public double Ar;
    public string Feltetek;

    //konstruktor
    public Pizza()
    {
        //üres konstruktor (nem csinál semmit)

    }

    public Pizza(string nev, int meret, double ar, string feltetek)
    {
        Nev = nev;
        Meret = meret;
        Ar = ar;
        Feltetek = feltetek;
    }

    //tetszőleges számú konstruktort készíteni

    public Pizza(string sor)
    {
        //Margherita;32;6.50;paradicsomszosz, mozzarella
        string[] darabok= sor.Split(';');

        //["Margherita", "32", "6,50", "paradicsom..."]
        Nev = darabok[0];
        Meret = int.Parse(darabok[1]);
        Ar = double.Parse(darabok[2]);
        Feltetek = darabok[3];
    }
    public string Megjelenit()
    {
        return $"{Meret} cm {Nev} {Ar} Euro";
    }
}