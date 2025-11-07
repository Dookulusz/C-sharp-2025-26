/* Kérjük be a felhasználótól
 * az osztálylétszamot
 * Hozzunk létra egy ekkora tömböt
 * for ciklus segítségével
 * kérjünk be neveket és tároljuk őket a tömb
 * megfelelő index helyén
 * A feltötlés után foreach ciklussal írjuk
 * ki a képrenyőre a neveket
 * */

Console.Write("Add meg a létszámot: ");
int letszam = int.Parse(Console.ReadLine());

string[] nevsor = new string[letszam];
string nev;

for (int i = 0; i < letszam; i++)
{
    Console.Write("Adj meg egy nevet:");
    nev = Console.ReadLine();

    nevsor[i] = nev; 
}

foreach (var cucc in nevsor)
{
    Console.WriteLine(cucc);
}