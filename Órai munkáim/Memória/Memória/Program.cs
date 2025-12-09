//egyszerű érték a stacken
int szam = 1;

//referencia a heapen
int[] tömb = new int [10];

//véletlenszám-generátor bevezetése
Random veletlen = new Random ();

//egyetlen véletlen szám generálása
szam = veletlen.Next();

int Szam(int kuszob = 0, int plafon = int.MaxValue)
{
    Random veletlen = new Random();
    int randomszam = veletlen.Next(kuszob, plafon);

    return (randomszam);

}

int Elso()
{
    int eredmény = Szam(0,10);

    return (eredmény);
}
Console.WriteLine(Elso());

int Masodik()
{
    int eredmény = Szam(0, 101);

    return (eredmény);
}
Console.WriteLine(Masodik());

bool Harmadik()
{
    bool dontes;

    int eredmény = Szam(0,2);

    if (eredmény == 0)
    {
        dontes = false;
    }
    else
    {
        dontes = true;   
    }
    return (dontes);
}
Console.WriteLine(Harmadik());

