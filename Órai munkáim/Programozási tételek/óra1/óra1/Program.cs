/* adott egy tulajdonság (tetszőleges mennyiségű adat)
 * Adott egy tulajdonság, ami az adatokon értelmezett.
 * A feladat annak hatékony eldöntése, hogy
 * tartalmaz-e ennek megfelelő elemet.
 */

//keressünk negatív számot
int[] szamok = [10, 20, 30, -5, 50, 0, -10];

//induljunk ki az első elemtől
int i = 0;

while (i < szamok.Length && szamok[i] >= 0)
{
    i++;
}

//mi a válasz?
if (i == szamok.Length)
{
    Console.WriteLine("Nem volt ilyen");
}
else
{
    Console.WriteLine("volt");
}