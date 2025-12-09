Console.WriteLine("Egy sima véletlen " + Szám(10,100));
Console.WriteLine("Százaléjk " + Százalék());
Console.WriteLine("Kockadobás " + Kocka());
Console.WriteLine("Számjegy " + Szamjegy());
Console.WriteLine("0 vagy 1 " + Bit());
Console.WriteLine("Igaz-Hamis " + Pénzfeldobás());

// Függvény, ami véletlenszerű igaz / hamis értéket ad vissza
static bool Pénzfeldobás()
{
    int szám = Bit();

    if (szám == 1)
    {
        return true;
    }

    return false;
}

// Random 0 vagy 1-et
static int Bit()
{
    return Szám(0, 1);
}

// decimális számjegyeket készít
static int Szamjegy()
{
    return Szám(0, 9 + 1);
}

// készítsünk egy függvényt, ami kockadobást valósít meg (1-2-3-4-5-6)
static int Kocka()
{
    return Szám(1, 6 + 1);
}

// Egész szám 0-tól 100-ig
static int Százalék()
{
    return Szám(0, 100 + 1);
}

// Tetszőleges egész szám
static int Szám(int küszöb, int plafon)
{
    // véletlen számokhoz példányosítani kell a Random osztályt
    Random rng = new Random();

    // egy konkrét véletlen értéket a Next() metódusokkal
    int veletlen = rng.Next(küszöb, plafon);

    // ezzel térünk vissza
    return veletlen;
}
