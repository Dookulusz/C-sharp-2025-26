/* adott egy tulajdonság (tetszőleges mennyiségű adat)
 * Adott egy tulajdonság, ami az adatokon értelmezett.
 * A feladat annak hatékony eldöntése, hogy
 * tartalmaz-e ennek megfelelő elemet.
 */

//keressünk negatív számot
int[] szamok = [10, 20, 30, -5, 50, 0, -10];

//induljunk ki az első elemtől
int i = 0;

//tároljuk a megoldást egy változóban
bool keresem = true;

//amíg a tömböt be nem jártuk és nincs válasz
while (i < szamok.Length && keresem)
{
    if (szamok[i] < 0)
    {
        //ne keressünk tovább
        keresem = false;
        break;
    }
    else
    {
        //menjünk tovább
        i++;
    }
}

//mi a válasz?
if (keresem)
{
    Console.WriteLine("Nem volt ilyen");
}
else
{
    Console.WriteLine("volt");
}