/* LINEÁRIS KERESÉS TÉTEL
 * 
 * Adott egy gyűjtemény és egy feltétel
 * illetve _biztosan_ tudjuk, hogy a gyűjteményben
 * van leaglább egy ilyen elem
 * Feladat. mi az első előfordulás indexe?
 */

string[] nevsor = ["Anita", "Bence", "Csaba", "...", "stb.", "Zoltán"];

Console.Write("Adj meg egy létező nevet: ");
string keresett = Console.ReadLine();

string vane = "Nincs";
int indexe = 0;

for (int i = 0; i < nevsor.Length; i++)
{
    if (nevsor[i] == keresett)
    {
        indexe = i;
        vane = "Van";
        break;
    }
}

Console.WriteLine($"Indexe: {indexe}");
Console.WriteLine($"Sorszáma: {indexe + 1}");
Console.WriteLine($"{vane} benne");
