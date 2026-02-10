//üres lista készítése
List<string> egyik = new List<string>();

//rövidíthető
List<string> masik = new();

//preferált alak
List<string> lista = ["Anita","Bence","Csaba"];

//lista visszaalakítása tömbbé
string[] tomb = lista.ToArray();

//fordítva is lehet
lista = tomb.ToList();

//elemek hozzáadása
lista.Add("Dénes");
lista.Add("Ferenc");

//sok elem felvétele
lista.AddRange(tomb);
lista.AddRange(["Gábor", "Helga"]);

//elemek elérése index segítségével
Console.WriteLine("ELső");
Console.WriteLine(lista[0]);
Console.WriteLine(lista[1]);

//első-utolsó elem gyakran kell
lista.First();
lista.Last();

//a valóban tárolt elemek száma
int elemszam = lista.Count;

//listák bejárása pont olyan mint a tömböké

for (int i = 0; i < lista.Count; i++)
{
    string akutális = lista[i];
    Console.WriteLine($"{i}. indexű: {akutális}");
}

// de persze működik foreach looppal is

foreach (var item in lista)
{
    Console.WriteLine(item);
}

//beszúr adott helyre
lista.Insert(0, "Zoltán");
lista.Insert(3, "Viktor");

/*Hasznos metódusok*/

//az első előfordulás törlése (ha egyáltalán létezik)
lista.Remove("Jolán");

// adott elem törlése
lista.RemoveAt(0);

//létezés ellenőrzés
lista.Contains("Keresett");

string keresett = "Pingvin";
while (lista.Contains(keresett))
{
    lista.Remove(keresett);
}

//első előfordulása indexének keresése
//(nem fagy le ha nem talált, de -1 et ad vissza)
lista.IndexOf("Keresett");

//utolsó elem kiiratása máshogy
Console.WriteLine(lista[^1]);


//helyben sorrend megfordítása
lista.Reverse();

//helyben rendezés
lista.Sort();

//minden elem törlése
lista.Clear();