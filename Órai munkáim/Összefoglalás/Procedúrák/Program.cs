var sorok = File.ReadAllLines("vegyszerek.csv");

List<Vegyszer> termekek = [];

foreach (var item in sorok)
{
    termekek.Add(new Vegyszer(item));
}

//1. Összár

double osszar = termekek.Sum(x => x.Mennyiseg * x.NettoAr * 1.27);
Console.WriteLine($"Fizetendő összeg: {osszar} Ft");

// 2. szilardak szama
int darab = 0;

foreach (var item in termekek)
{
    if (item.Egyseg == "g")
        {
        darab++; 
        }
}

Console.WriteLine($"Darabszám:" + darab);















// 4. Írja konzolra, hány sor található a fájlban!



// 5. Vezzessen be egy Vegyszer példányok
// tárolására alkalmas tömböt vagy listát Termékek néven!
// (Tömb esetén megfelelő mérettel!)

// 6. Dolgozza fel a forrásfájl sorait! 
// Mindegyik szöveges sorból készítsen egy új Vegyszer példányt,
// és tárolja el a Termékek gyűjteményeben!

/*********************************/

// A tanult programozási tételek alkalmazásával
// válaszoljon az alábbi kérdésekre:

// 1. Mennyi a terméket után fizetendő teljes összeg?

// 2. Hány darab szilárd halmazállpotú van köztük?
// (szilárd vegyszer az, aminek az Egységét grammban adták meg)

// 3.a) Mi a legdrágább vegyszer indexe? (_hányadik_ elem a legnagyobb)
// 3.b) Mi ennek a megnevezése?

// Lehet akár két lépésben is:
// - először, hogy mennyi a legnagyobb értéke
// - majd az ilyen értékű elem hol van (Kiválasztás progtétel)

// 4.a) Kérjen be a felhasználótól egy keresett nevet!
// 4.b) Van-e ilyen megnevezésű vegyszer a termékek között?
// (elég "igaz-hamis" válasz, lényegtelen hol van, vagy hány ilyen van)

// 5. Válogassa ki a drága vegyszereket egy új listába!
//    (a Fizetendő összege több mint 10.000 forint)

/* Ennek algoritmusa:
    * 
    * függvény Kiválogat ( eredeti )
    *    
    *    drágák legyen új gyűjtemény
    *    
    *    minden elemre az eredetiben ismételd
    *       ha az aktuális elem megfelelő, akkor
    *         drágákhoz hozzáad aktuálisat
    *       elágazás vége
    *    ismétlés vége
    *    
    *    visszaad drágák
    *    
    *  függvény vége
    */
