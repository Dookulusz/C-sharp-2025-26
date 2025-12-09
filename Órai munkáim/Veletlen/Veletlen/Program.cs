int Szam()
{
    Random rng = new Random();

    int veletlen = rng.Next(0, 10 + 1);
    return veletlen;
}
Console.WriteLine($"Random szam(1-10): {Szam()}");

int Tudadszam(int a, int b)
{
    Random rng = new Random();

    int veletlen = rng.Next(a, b + 1);

    return veletlen;
}

int Kocka()
{
    int szazalek = Tudadszam(1,6);
    return szazalek;
}

Console.WriteLine($"A dobott szám: {Kocka()}");

//aero fügvény (nem tananygag)
int Majom() => Tudadszam(1, 6);
Console.WriteLine($"Nyílfügvény: {Majom()}");

bool Pénzfeldobás()
{
    int szam = Tudadszam(0, 1);

    if (szam == 1)
    {
        return true;
    }

    return false;
}
Console.WriteLine(Pénzfeldobás());

//kesz



