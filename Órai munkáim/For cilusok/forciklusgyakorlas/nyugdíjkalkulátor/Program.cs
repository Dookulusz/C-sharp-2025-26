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
 *   de legfeljebb 130_000 Ft.ot évente.
 *   
 */

int kor;
int korhatar = 0;
string nem;
double félretett;
double kamat = 1.065;
double allam = 0;

Console.Write("Hány éves vagy: ");
kor = int.Parse(Console.ReadLine());

Console.Write("Nemed: ");
nem = Console.ReadLine();

while (nem != "férfi" && nem != "nő")
{
    Console.Write("Add meg rendesen koma: ");
    nem = Console.ReadLine();
}

Console.Write("Mennyit tesz félre: ");
félretett = double.Parse(Console.ReadLine());

double félretetteves = félretett * 12;

if (nem == "férfi")
{
    korhatar = 65;
}

else if (nem == "nő")
{
    korhatar = 62;
}

for (int i = kor; kor < korhatar; kor++)
{
    int kedvezmeny;

    if (félretetteves * 0.2 > 130_000 )
    {
        kedvezmeny = 130_000;
    }

    félretett *= kamat;

}

Console.WriteLine($"A megtakarított pénzed nyugdíjbavonuláskor: {félretett}");
Console.WriteLine($"A pénzed az állam támogatásával: {allam}");