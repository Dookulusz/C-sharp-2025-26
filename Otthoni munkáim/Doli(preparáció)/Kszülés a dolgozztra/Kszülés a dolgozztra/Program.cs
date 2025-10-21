//1. feladat

/*
for (int i = 1; i <= 10;i++)
{
    Console.WriteLine(i);
}
*/

//2. feladat

/*
for (int i = 1; i <= 20; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine($"{i}, 2-vel osztható");
    }
}
*/

//3. feladat

/*
Console.Write("Addj meg egy számot: ");
int szam = int.Parse(Console.ReadLine());
int összeg = 1;

for (int i = 1; i <= szam; i++)
{
    összeg = összeg + i;
}

Console.WriteLine(összeg);
*/

//4. feladat


Console.Write("Addj meg egy számot: ");
int szam = int.Parse(Console.ReadLine());
int osszeg = 0;


while (szam > 0)
{
    osszeg += szam % 10;
    szam /= 10;
}

Console.WriteLine(osszeg);


//5. feladat

/*
Console.Write("Addj meg egy számot: ");
int szam = int.Parse(Console.ReadLine());
string helyzet;

if (szam % 2 == 0)
{
    helyzet = "páros";
}
else
{
    helyzet = "páratlan";
}

Console.WriteLine($"A megadot szám: {helyzet}");
*/

//6. feladat

/*
Console.Write("Addj meg egy számot: ");
int szam = int.Parse(Console.ReadLine());

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"{i} * {szam} = {i * szam}");
}
*/



/*
 * Egyszerű ismétlések és feltételek (1–5)
1. Írd ki az 1-től 10-ig tartó számokat for ciklussal!
2. Írd ki az 1 és 20 közötti páros számokat!
3. Kérj be egy számot n, és számítsd ki az 1 + 2 + … + n összeget!
4. Kérj be egy számot, és írd ki a számjegyeinek összegét (while ciklussal)!
5. Kérj be egy számot, és döntsd el, hogy páros vagy páratlan!
🟡 Középhaladó – beágyazott ciklusok és feltételek (6–10)
6. Kérj be egy számot, és írd ki a szorzótábláját 1-től 10-ig!
7. Rajzolj ki egy balra igazított háromszöget csillagokból!
9. Számítsd ki a faktoriálist (n! = 1 * 2 * … * n) for ciklussal!
10. Írj programot, ami megszámolja, hány páros szám van egy megadott tartományban!
🟠 Nehézségi szint emelkedik (11–15)
11. Kérj be számokat addig, amíg a felhasználó 0-t nem ír, majd írd ki az átlagukat!
12. Kérj be egy számot, és döntsd el, hogy prímszám-e!
13. Írd ki az összes prímszámot 1 és n között!
14. Kérj be két számot, és számítsd ki az Euklidesz-algoritmussal!
15. Kérj be egy számot, és írd ki, hány nulla, páros és páratlan számjegyet tartalmaz!
🔵 Komolyabb logikai feladatok (16–20)
16. Írj programot, ami kiírja az első n Fibonacci-számot!
17. Kérj be egy számot, és írd ki fordítva (pl. 1234 → 4321)!
18. Kérj be egy számot, és döntsd el, hogy palindróm-e (előre és hátra olvasva ugyanaz)!
19. Írj programot, ami kiírja az összes tökéletes számot 1 és n között!
20. Kérj be két számot (kezdet, vég), és írd ki az összes Armstrong-számot a tartományban!
*/