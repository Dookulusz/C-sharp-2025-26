/*
 * - Hány éves vagy?
 * 
 * - Férfi / Nő
 * 
     * Nyugdíjkorhatárok:
     * F: 65
     * N: 62
 * 
 * - Mennyit tesz félre havonta? 
 * 
 * - Kamatláb legyen 6.5%
 *   Számítsuk ki, hogy nyugdíjba vonuláskor
 *   mennyi megtakarított pénzünk lesz.
 * 
 * - Minden év végéen az állam jóváírja
 *   az adott évebn befizetett összeg 20%-át
 *   de legfeljebb 138_000 Ft.ot évente.
 */
int kor;
string nem;
double félretett;
double kamat = 1.065;

Console.WriteLine("Hány éves vagy: ");
kor = int.Parse(Console.ReadLine());

Console.WriteLine("Nemed: ");
nem = Console.ReadLine();

while (nem != "férfi" || nem != "nő")
{
    Console.WriteLine("Add meg rendesen");
    nem = Console.ReadLine();
}

Console.WriteLine("Mennyit tesz félre: ");
félretett = double.Parse(Console.ReadLine());

if (nem == "férfi")
{

}
else if (nem == "nő")
{

}