var sorok = File.ReadAllLines("vegyszerek.csv");

//feldolgozas
List<Vegyszer> termekek = sorok.Select(sor => new Vegyszer(sor)).ToList();

//1. Összár
double osszar = termekek.Sum(x => x.Mennyiseg * x.NettoAr * 1.27);
Console.WriteLine($"Fizetendő összeg: {osszar} Ft");

// 2. szilardak szama
int darab = termekek.Count(x => x.Egyseg.Equals("g")); // "==" is jó;
Console.WriteLine(darab + "db");

//3. Legolcsóbb
int minimum = termekek.Min(x => x.NettoAr);
Console.WriteLine(minimum + "ft");


