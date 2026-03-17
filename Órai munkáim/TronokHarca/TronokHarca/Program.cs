/* FÁJLKEZELÉS 
 * 
 * Adja hozzá a "forras.txt" forrásfájlt a projecthez!
 * Automatikusan kerüljön a bin/debug könyvtárba!
 * A fájlból olvasson be minden sort!
 *
 * FELDOLGOZÁS
 * 
 * Alakítsa a szöveges sorokat Szereplo példányokká!
 * Ehhez használja az osztály konstruktorát!
 * Tárolja az adatokat Szereplőkből álló listában!
 * 
 * FELADATOK
 * 
 * LINQ függvényekkel válaszoljon a kérdésekre!
 * 
 */
using System.ComponentModel;

var sorok = File.ReadAllLines("forras.txt");

List<Szereplo> lista = [];

foreach (var item in sorok)
{
    lista.Add(new Szereplo(item));
}

// 1. Hány szereplője van a sorozatnak?

Console.WriteLine("1. feladat");
Console.WriteLine($"A sorozatnak {lista.Count()} szereplője volt.");
Console.WriteLine();

// 2. A színészek évadonként átlagosan hányszor szerepeltek?
// (mennyi a színészek Átlagos Szereplésének átlaga)

Console.WriteLine("2. feladat");
Console.WriteLine($"Átlagosan {lista.Average(x => x.AtlagosSzereples())} évadban szerepeltek");
Console.WriteLine();

// 3. Melyik évben volt a sorozat első és utolsó évada?

Console.WriteLine("3. feladat");
Console.WriteLine($"Az első évad {lista.Min(x => x.MikorElso)}, az utolsó {lista.Max(x => x.MikorElso)}");
Console.WriteLine();

// 4. Számolja meg a Stark családba tartozó karaktereket!
// (hány karakternek a neve végződik arra, hogy "Stark")

Console.WriteLine("4. feladat");
Console.WriteLine($"A Stark család {lista.Count(x => x.KarakterNev.EndsWith("Stark"))} fős.");
Console.WriteLine();

// 5. Volt aki az elejétől a végéig túlélte mind a 9 évadot?
// (bárkinek az évadok száma megegyezik 9-cel?)
Console.WriteLine("5. feladat");

if (lista.Any(x => x.Epizod.Equals(9)))
{
    Console.WriteLine("volt");
}
else
{
    Console.WriteLine("nem volt");
}
Console.WriteLine();


// 6. Minden szereplő megélt legalább 2 évadot?
Console.WriteLine("6. feladat");

if (lista.All(x => x.Epizod >= 2))
{
    Console.WriteLine("volt");
}
else
{
    Console.WriteLine("nem volt");
}
Console.WriteLine();


// 7. Szerepelt-e benne adott nevű színész? (például "Kit Harington")
Console.WriteLine("7. feladat");

int volte = lista.Count(x => x.KarakterNev == "Kit Harington");
if (volte == 0)
{
    Console.WriteLine("Nem volt");
}
else
{
    Console.WriteLine("Volt");
}
Console.WriteLine();


// 8. Mi a 3 legtöbbet szereplő színész neve?
// (epizódok száma szerint csökkenőbe rendezve az első három)
Console.WriteLine("8. feladat");
Console.WriteLine();
Console.WriteLine();



// 9. Válogassa ki új tömbbe a több mint 8 évadban szereplőket!
// (használja hozzá a Szereplő példány EvadokSzama metódusát)
Console.WriteLine("9. feladat");
Console.WriteLine();
Console.WriteLine();


/* SZORGALMI
 * 
 * Bővítse a szereplő osztályt egy NemesiSzuletes tulajdonsággal.
 * Westeroson a közembernek egyetlen neve van ("Irri", "Qyburn"),
 * a nemeseknek rendelkeznek családnévvel is. 
 * Ez a tulajdonság megállapítja, hogy a név több szóból áll-e.
 * 
 * Bővítse a szereplő osztályt egy Csaladinev tulajdonsággal,
 * ami a karakter nevét szóközök mentén darabolva az utolsó darabot adja vissza.
 * 
 * Szűrjön a szerpelők közül a nemesi születésűekre,
 * válassza ki a családnevüket, és távolítsa el az ismétlődéseket.
 * 
 * Minden családnévhez számolja meg a családtagok számát!
 * Csak azokat írja a képernyőre, akiknek 1-nál több tagja van!
 */

Console.ReadKey();