//Létezik egy elpőre importált névtér (modul)
//Ez System.Linq; (helyesen ejtsd: 'link')
//Ez taralmazza az adatbázis kezelő parancsokat
//Később fogjuk használni őket.

//deklaráció

string szoveg;

//értékadás idézőjellel

szoveg = "lorem ipsum";

//osztály adatai

int hossza = szoveg.Length;

/*SZÖVEGMŰVELETEK */

szoveg.StartsWith("elején ez van:");
szoveg.EndsWith("Ez van a végén");
szoveg.Contains("taralmazza-e?");

//csupa nagybetű
string nagybetus =szoveg.ToUpper();

//csupa kisbetű
string kisbetus = szoveg.ToLower();

//módosítás
szoveg = "árvíztúrő tükörfúrógép";

//karaktercsere
szoveg.Replace('á', 'í');

//szövegrészlet csere
string cserelt = szoveg.Replace("tükör", "kutya");

Console.Write("Eredeti: ");
Console.WriteLine(szoveg);

Console.Write("Csere után: ");
Console.WriteLine(cserelt);

//Egyetlen lépésben megoldható felülírással
szoveg = szoveg.Replace("fúró", "poszáta");
Console.Write("2. Csere után: ");
Console.WriteLine(szoveg);

//szövegdarabolás
//(Az első hány karaktert tartsunk meg)
string reszlet = szoveg.Remove(10);
Console.WriteLine(reszlet);

// Honnan indulva hány karaktert töröljünk
reszlet = szoveg.Remove(10, 5);
Console.WriteLine("A 10. után 5 karakter");
Console.WriteLine(reszlet);

//az első előfordulás helye
int helye = szoveg.IndexOf("gép");
Console.WriteLine("A keresett szöveg elsp előfordulása");
Console.WriteLine(helye);

helye = szoveg.IndexOf("csillámpóni");
Console.WriteLine("Nincs ilyen egyezés");
Console.WriteLine(helye);

//A tanárúr által preferált megoldás

Console.WriteLine("Mit keresel?: ");
string keresett = Console.ReadLine();

//először vizsgáljuk, hogy tartalmazza-e
if (szoveg.Contains(keresett))
{
    //ha igen, megallapítjuk a helyét
    int itt = szoveg.IndexOf(keresett);
    Console.WriteLine($"Egyezés itt: {itt}");
}
else
{
    Console.WriteLine("Nincs egyezés");
}

