/*
 * Kamatos kamat
 * 
 * kamatláb legyen 1%
 * 
 * Kérjük be a befektetés összegét (double)
 * Kérjük be a hosszák (hetek számát)
 * Ciklus segítségével számítsünk kamatos kamatot
 * A befektettett összeg nő a kamatlábbal.
 * 
 * Írjuk ki a befektetés összegét
 * Illetve a százalékos növekedés
 */

double befektetes;
double kamatlab = 1.01;
int hetekszama;

Console.WriteLine("Kamatos kamat kalkulátor");
Console.WriteLine();

Console.Write("Add meg a befektetés összegét: ");
befektetes = double.Parse(Console.ReadLine());

Console.Write("Add meg a hetek hosszát: ");
hetekszama = int.Parse(Console.ReadLine());

for (int i = 1; i <= hetekszama; i++)
{
    befektetes *= kamatlab;
}
Console.WriteLine($"{Math.Round(befektetes, 2)} forint");
