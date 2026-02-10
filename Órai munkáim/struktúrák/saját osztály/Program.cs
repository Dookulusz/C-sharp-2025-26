// ostály leírásból példány készítése
Diak peldany = new Diak("Dániel", 11, 'C');

// automatikusan szöveggé lesz alakítva
Console.WriteLine("kiíratás");
Console.WriteLine(peldany);
Console.WriteLine();

Console.WriteLine("Adatok egyesével");
Console.WriteLine(peldany.Nev);
Console.WriteLine(peldany.Evfolyam);
Console.WriteLine(peldany.Kod);

//"szátszerelni" is lehet
(string Nev, int Evfolyam, char Kod) = peldany;
Console.WriteLine(Nev);
Console.WriteLine(Evfolyam);
Console.WriteLine(Kod);

//saját osztály definíciója
record class Diak(string Nev, int Evfolyam, char Kod);



