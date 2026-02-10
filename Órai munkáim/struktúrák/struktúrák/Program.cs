//adatok
int year = 2026;
int month = 01;
int day = 05;
int hour = 10;
int minute = 30;

// függvény hívása
DatumKiirat(year, month, day);

//függvény definíció
void DatumKiirat(int y, int m, int d)
{
    Console.WriteLine($"{y}-{m}-{d}");
}

// léteznek beépített struktúrák
//a gyakran használt adatokhoz

DateTime most = DateTime.Now;
Console.WriteLine(most);

DateTime epoch = new DateTime();
Console.WriteLine(epoch);

DateTime custom = new DateTime(2026, 1, 5, 10, 30, 00);
Console.WriteLine(custom);

DateTime szövegből = DateTime.Parse("2026-01-05 10:30:00");
/*
12.31.2026
2026.01.05
2026.1.5

Ezek mind megfelelő leírások
 */
Console.WriteLine(szövegből);


Masikkiiratas(szövegből);
void Masikkiiratas(DateTime datum)
{
    Console.WriteLine($"Év:{datum.Year} hónap:{datum.Month} nap:{datum.Day}");
}
