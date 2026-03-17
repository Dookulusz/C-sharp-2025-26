List<int> lista = [-2, -1, 0, 1, 2, 3, 4, 5, 6];

//mindig működik
lista.Count();
lista.First();
lista.Last();
lista.ToList();
lista.ToArray();

//aggregálás
lista.Sum();
lista.Average();
lista.Min();
lista.Max();


List<string> nevsor = ["Anita", "Bence", "Csaba", "Dóka", "Elemér"];

//nevek > hosszának > minimuma
nevsor.Select(nev => nev.Length).Min();

//nevekből > Diak > lista
nevsor.Select(nev => new Diak(nev));

// * NÉVTELENE NYÍL FÜGGVÉNY * //

var pozitivakszama = lista.Count(szam => szam > 0);

/* Ezt csinálja a 27. sor :)
bool Pozitiv(int szam)
{
    return szam > 0;
}
*/

var elsoparosszam = lista.First(paros => paros % 2 == 0);

var nevhosszakatlaga = nevsor.Select(nev => nev.Length).Average();
var legrovidebbnev = nevsor.Min(nev => nev.Length);

// * SZŰRÉS * //

List<int> pozitivak = lista.Where(x => x > 0).ToList();
List<int> parosszamok = lista.Where((x) => x % 2 == 0).ToList();

lista.Where(x => x > 0).Where(x => x % 2 == 0);
lista.Where(x => x > 0 && x % 2 == 0);
//46 és 47. sor ugyanaz csak máshogy kifejezve

// * RENDEZÉS * //

//nevek hossza szerint rendezve
nevsor.OrderBy(nev => nev.Length);

var result = nevsor
    .Where(nev => nev.Length > 0)
    .OrderBy(nev => nev.Length)
    .Skip(3)
    .Take(3)
    .ToList();

//fordítva rendezés
nevsor.OrderBy(nev => nev.Length).Reverse();

//vagy egytelen lépésben
nevsor.OrderByDescending(nev => nev.Length);

//többszörös rendezés

List<Dolgozat> beszedes = [];

//rendeezzeők őket eredmény szerint 
//azonod eredmény osztály szerint   
//azonos osztályokat név szerint
//például
// 5 - 11 - Dénes
// 5 - 11 - Ferenc
// 5 - 12 - Csaba
// 4 -  9 - Anita

var rendezve = beszedes
    .OrderBy(x => x.Eredmenye)
    .ThenBy(x => x.Osztály)
    .ThenBy(x => x.Nev);

//logikai művelete (van benne valami, mindegyik ilyen)
//de ez egyelten konkrét adatot vár
//nincs lehetőség feltétel megadására
lista.Contains(10);

// van-e a beszedett dolgoztok között elégtelen
// egyik ötletl: számoljuk meg! ha 0 darab van -> akkor nincs.
int darab = beszedes.Count(x => x.Eredmenye == 1);

if (darab == 0)
{
    Console.WriteLine("Nincs");
}
else
{
    Console.WriteLine("Volt");
}

int atment = beszedes.Count(x => x.Eredmenye > 1);

if (atment == beszedes.Count)
{
    Console.WriteLine("Mindenki átment");
}
else
{
    Console.WriteLine("Volt aki nem");
}


//van legalább egy
beszedes.Any(x => x.Eredmenye == 1);

//mindegyik ilyen
beszedes.All(x => x.Eredmenye > 1); 

class Dolgozat
{
    public int Eredmenye { get; set; }
    public int Osztály { get; set; }
    public string Nev { get; set; }
}

record class Diak(string nev);
