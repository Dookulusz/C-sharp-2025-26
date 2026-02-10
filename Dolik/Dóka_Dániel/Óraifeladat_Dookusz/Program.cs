using System.Globalization;

string[] tartalom = File.ReadAllLines("leltar.csv");

List<Konyv> konyv = [];



foreach (var item in tartalom.Skip(1))
{
    konyv.Add(new Konyv(item));
}



while (true)
{
    Console.WriteLine("Adj meg egy címet: ");
    string konyvnev = Console.ReadLine();

    if (konyvnev == string.Empty)
    {
        break;
    }

    foreach (var item in konyv)
    {
        if (item.Cim.Contains(konyvnev))
        {
            item.Allapotvaltas();
        }
    }
}

List<string> üres = [];

foreach (var item in konyv)
{
    if (item.Kolcsonzott == true)
    {
        string alakit = item.SzoveggeAlakit();
        üres.Add(alakit);
    }
}

File.WriteAllLines("mentes.csv", üres);

