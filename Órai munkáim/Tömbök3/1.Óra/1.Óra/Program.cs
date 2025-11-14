using System.Linq;

int[] tomb = [1, 2, 3, 4, 6];
int páros = 0;
foreach (var cucc in tomb)
{
    if (cucc % 2 == 0)
    {
        páros++;
    }
}
Console.WriteLine($"páros számok a tömben: {páros}");

string[] tomb1 = ["majom", "jaguar", "kecske", "", "maugli", ""];

int üres = 0;

foreach (var item in tomb1)
{
    if (item == string.Empty)
    {
        üres++;
    }
}
Console.WriteLine($"Ennyi fő nem adta meg a nevét: {üres}");

int[] tomb3 = [1, 2, 3, 4, 4, 24, 4, 6, 34, -5, 245, 2348, 538, 393];

int min = 0;
int  max = 0;

int egyforma = 0;
int mennyi = 0;
int melyik = 0;

foreach (var kicsi in tomb3)
{
    if (min > kicsi)
    {
        min = kicsi;
    }
    if (max < kicsi)
    {
        max = kicsi;
    }
}

Array.Sort(tomb3);

for (int i = 0; i < tomb3.Length; i++)
{
   
    if (egyforma == tomb3[i])
    {
        melyik = tomb3[i];
        mennyi++;
    }

    egyforma = tomb3[i];
}
Console.WriteLine($"A legkisebb: {min}");
Console.WriteLine($"A legnagyobb: {max}");
Console.WriteLine($"A {melyik}-ből van {mennyi + 1} darab");


int[] tomb4 = [10, 20, 30, 40];

int meret = tomb4.Length;

int[] klón = new int[meret];

for (int j = 0; j < meret;j++)
{
    klón[j] = tomb4[j];

}


string[] tomb5 = ["daniel.doka22@gmail.com", "daniel.doka@umszki.hu", "dookusz.kookusz@gmail.com"];

string[] szűrt = new string[tomb5.Length];
int darab = 0;

foreach (var item in tomb5)

{
    if (item.EndsWith("@umszki.hu"))
    {
        szűrt[darab] = item;
        darab++;
    }
}
Console.WriteLine($"Ezek a megfelelő értékek: ");
for (int k = 0; k < darab; k++)
{
    Console.WriteLine(szűrt[k]);
}

Console.WriteLine("vége");