//saját "parancs+" bevezetése
//[típus] Azonosító()
// {
//  utasítások
// }

//fügvény átnevezése: Ctrl + r + r

void Elvalaszto()
{
    Console.Clear();
    Console.WriteLine("##############");
    Console.WriteLine("# 1. FELADAT #");
    Console.WriteLine("##############");
    Console.WriteLine();
}

Elvalaszto();

int Negyzet()
{
    int szam = 10;
    int negyzet = szam * szam;

    //a kiszámolt eredmény visszaadása a hívónak
    return negyzet;
}

//Függvény hívása, és visszatérési érték tárolása
int eredmény = Negyzet();

//másik példa
int result = összeg();

Console.WriteLine(result);

static int összeg()
{
    int egyik = 10;
    int másik = 20;
    int result = egyik + másik;
    return result;
}

//másik példa

string[] nevsor = ["anita", "bence", "csaba"];

string osszefuzve = "";
foreach (var item in nevsor)
{
    osszefuzve += item + " ";
}

Console.WriteLine(osszefuzve);

