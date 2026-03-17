var sorok = File.ReadAllLines("vegyszerek.csv");

//pédlányosítsik az osztályt
Megrendeles kosar = new();

//feldolgozas
kosar.Import(sorok);

//1. Összár
Console.WriteLine($"Fizetendő összeg: {kosar.Fizetendo} Ft");

// 2. szilardak szama

Console.WriteLine($"Darabszam? {kosar.Szilardakszama}");

//3. Legolcsóbb
Console.WriteLine($"{kosar.Legolcsobb().NettoAr} Ft");
        



