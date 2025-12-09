using Microsoft.Win32.SafeHandles;
using System.Text.Json.Serialization.Metadata;
using System.Threading.Channels;

int[] tömb = [10, 20, 30, 40, 50, 51, 61];

/* Készítsünk egy kiírható eljérést (void)
 * ami egy tömb adatait megjeleníti a képeryőn
 */
int Alma(int alma)
{
    Console.WriteLine($"{alma}. Feladat");
    return alma;
}
Alma(1);

void Display(int[] tömb)
{
    foreach (var item in tömb)
    {
        Console.Write($"{item}, ");
    }
}
Display(tömb);
/*Függvényt, ami kiszámlja egy tömkb összegét*/
Console.WriteLine();
Alma(2);
int Sum(int[] tömb)
{
    int összeg = 0;

    foreach (var item in tömb)
    {
        összeg += item;
    }
    return összeg;
}
int szumma = Sum(tömb);

Console.WriteLine($"Az számok összege: {szumma}");

/*Függvényt, ami megszámolja a pozitív számokat*/
Alma(3);
int Count(int[] tömb)
{
    int poz = 0;
    foreach (var item in tömb)
    {
        if (item > 0)
        {
            poz++;
        }
    }
    return poz;
}
int kokusz = Count(tömb);
Console.WriteLine($"Pozitív számok száma: {kokusz}");

/*Függvény ami eldönt, hogya van-e benne egy keresett szám*/
Alma(4);
string Vane(int[] tömb)
{
    Console.Write("Írj be egy számot: ");
    int keresett = int.Parse(Console.ReadLine());
    string van = "Nincs";

    foreach (var item in tömb)
    {
        if (item == keresett)
        {
            van = "Van";
            break;
        }
    }
    return van;
}
var cucc = Vane(tömb);
Console.WriteLine($"{cucc} benne");


/*Függvényt, ami egy keresett elem indexét adja meg*/
Alma(5);
int Index(int[] tömb, int szám)
{
    int keres = szám;
    int indexe = 0;

    for (int i = 0; i < tömb.Length; i++)
    {
        indexe = i;
        if (tömb[i] == keres)
        {
            return indexe;
        }
    }
    return indexe;
}
int indexelek = Index(tömb, 6);
Console.WriteLine($"{indexelek}");

/*Függvényt, ami átméretez egy tömböt*/
Alma(6);
void ReSize(int[] tömb, int ujtombhossz)
{
    Console.WriteLine("Eredeti tömb:");
    foreach (var item in tömb)
    {
        Console.Write($"{item}, "); 
    }

    Console.WriteLine();

    Console.WriteLine("Változtatott tömb:");

    int[] ujtömb = new int[ujtombhossz];

    for (int i = 0; i < tömb.Length; i++)
    {
        if (tömb.Length > ujtömb.Length)
        {
            for (int j = 0; j < ujtombhossz; j++)
            {
                ujtömb[j] = tömb[j];
            }
        }
        else
        {
            ujtömb[i] = tömb[i];
        }
        //az megvan hogy bővíteni, de ha csökkenteni kell akor az cumi egyenlőre
    }

    foreach (var item in ujtömb)
    {
        Console.Write($"{item}, ");
    }
}

Console.Write("Add meg az új tömböd hosszúságát: ");
int szamos = int.Parse(Console.ReadLine());

ReSize(tömb, szamos);
Console.WriteLine();

/*F�ggv�ny, ami egy �j t�mbbe v�logatja a param�terk�nt
 *kapott t�mbb�l pozit�v sz�mokat, �s ezzel a sz�rt t�mbbel t�r vissza.*/
Alma(6);
void Filter(int[] tömb)
{
    Console.WriteLine("Eredeti tömb:");
    foreach (var item in tömb)
    {
        Console.Write($"{item}, ");
    }

    Console.WriteLine();

    int pozit = 0;
    for (int i = 0; i < tömb.Length; i++)
    {
        if (tömb[i] % 2 == 0)
        {
            pozit++;
        }
    }

    int[] poztömb = new int[pozit];

    for (int i = 0;i < tömb.Length;i++)
    {
        if (tömb[i] % 2 == 0)
        {
            poztömb[i] = tömb[i];
        }
    }
    Console.WriteLine("Az új tömb amibe csak páros számok vannak: ");
    foreach (var item in poztömb)
    {
        Console.Write($"{item}, ");
    }
}
Filter(tömb);
Console.WriteLine();