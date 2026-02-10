/*Készítsünk egyszerű naplózó pogramot!
 * 
 * Vezessünk be egy listát kezdeti értékkel
 * amiben a tanár kézzel beírta a jelenlévőket!
 * (Anita, Bence, Csaba,....., stb..)
 * 
 * Készítsünk egy üres listát a késők tárolásához!
 * Ciklus segítségével kérjünk be neveket,
 * és tároljuk ebben a listában! Az ismétélst addig 
 * folytatjuk, amíg ütrs szövegeket nem kaptunk
 * (entert ütöttek szöveg beírása nélkül)
 * 
 * Egyesításe a két listát egyetlen gyűjteményben!
 * szűrje ki belőle az istmétlődéseket, és készítsen
 * egy listát, amiben csak egyedi értékek vannak
 * Rendezze ezt betűrendbe! írja ki a képernyőre a diákok
 * nevét és állapítsa meg az osztálylétszámot!
 */

List<string> jelenlevok = [];

Console.WriteLine("Jelenlévők neve: ");

string nev = Console.ReadLine();

while (nev != string.Empty)
{
    jelenlevok.Add(nev);
    nev = Console.ReadLine();
}

List<string> kesok = [];

Console.WriteLine("Késők neve:");

string kesokneve = Console.ReadLine();

while (kesokneve != string.Empty)
{
    kesok.Add(kesokneve);
    kesokneve = Console.ReadLine();
}

List<string> teljesnevsor = [];


int hossz1 = jelenlevok.Count;

for (int i = 0; i < hossz1; i++)
{
    teljesnevsor.Add(jelenlevok[i]);
}

int hossz2 = kesok.Count;

for (int i = 0; i < hossz2; i++)
{
    teljesnevsor.Add(kesok[i]);
}

foreach (var item in teljesnevsor)
{
    Console.WriteLine(item);
}
Console.WriteLine("kik hiányoztak?: ");

string nevcsekk = teljesnevsor[0];

List<string> szurt = [];

//NIncs kész!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!


Console.WriteLine("A végső névsor");

foreach (var item in teljesnevsor)
{
    Console.WriteLine(item);
}