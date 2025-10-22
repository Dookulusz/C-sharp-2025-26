//1. feladat

string nevsor;
string aktual = "";
int jelenlevok = 0;

while (true)
{
   Console.Write("Adj meg egy nevet: ");
   nevsor = Console.ReadLine();

    if (nevsor == "")
    {
        Console.WriteLine("Üres szöveg :/");
        break;
    }
    else
    {
        aktual = aktual + nevsor + "\n";
        jelenlevok++;
    }

}

Console.WriteLine(aktual);
Console.WriteLine($"Ennyi ember volt a névsorba: {jelenlevok}");

//2. feladat

Console.Write("Add meg az osztályod létszámát: ");
int letszam = int.Parse(Console.ReadLine());

int hianyzokszama = letszam - jelenlevok;

string hianyzok = "";

Console.WriteLine($"Ennyi ember hiányzik: {hianyzokszama}");

for (int i = 1; i <= letszam - jelenlevok; i++ )
{
    Console.Write("Add meg hogy ki hiányzik: ");
    hianyzok = Console.ReadLine();

    aktual = aktual + hianyzok + "\n";
}

Console.WriteLine(aktual);

/*
 * # Jelenléti ív

## 1. feladat
- Készítsünk konzolos alkalmazást. 
- Vezessünk be egy szöveges változót a névsor tárolásához
- és egy egész számot az jelenlévők számának tárolásához!

- Egy praktikusan választott ciklusban végezzük el a következő lépéseket:
    - Olvassunk be egy nevet! 
    - Ellenőrizzük, hogy nem üres szöveget kaptunk-e!
    - Ha nem üres, akkor adjuk hozzá a névsorhoz egy sortörés karakterrel,
    - majd növeljük a jelenlévők számát eggyel!
    - Oldjuk meg, hogy az ismétlés megszakadjon, ha üres szöveget kapunk!

- Ezután írjuk ki a névsort és a jelenlévők számát a képernyőre!

## 2. feladat

- Kérjük be az osztálylétszámot egy egész szám változóba!
- Számoljuk ki a hiányzók számát (osztálylétszám - jelenlévők)!
- Készítsünk egy for ciklust, ami pontosan ennyiszer ismétli meg,
- hogy bekéri egy hiányzó nevét, és hozzáadja őket a névsorhoz!
*/