Iroda iroda = Iroda.Parse(File.ReadAllLines("AdatokHU.csv"));

Console.WriteLine("Ingatlanok száma:");
Console.WriteLine(iroda.IngatlanokSzama);


Console.WriteLine("\nEladó ingatlanok:");
foreach (var x in iroda.EladoIngatlanok())
{
    Console.WriteLine(x.Telepules);
}


Console.WriteLine("\nNagyobb mint 80 m²:");
foreach (var x in iroda.NagyobbAlapteruletMint(80))
{
    Console.WriteLine(x.Terulet);
}


Console.WriteLine("\nOlcsóbb Budapesten:");
foreach (var x in iroda.OlcsobbAdottTelepulesen(50, "Budapest"))
{
    Console.WriteLine(x.Ar);
}


Console.WriteLine("\nFöldszintes:");
foreach (var x in iroda.FoldszintesIngatlanok())
{
    Console.WriteLine(x.Emelet);
}


Console.WriteLine("\nÁr szerint:");
iroda.ArSzerintNovekvo().ForEach(Console.WriteLine);


Console.WriteLine("\nAlapterület csökkenő:");
foreach (var x in iroda.AlapteruletCsokkeno())
{
    Console.WriteLine(x.Terulet);
}


Console.WriteLine("\nSzoba szerint:");
foreach (var x in iroda.SzobaSzerintCsokkeno("Budapest"))
{
    Console.WriteLine(x.Szobak);
}


Console.WriteLine("\nAlapterületek:");
foreach (var x in iroda.Alapteruletek())
{
    Console.WriteLine(x);
}


Console.WriteLine("\nNégyzetméter árak:");
foreach (var x in iroda.NegyzetmeterArak())
{
    Console.WriteLine(x);
}


Console.WriteLine("\nÁtlagár:");
Console.WriteLine(iroda.Atlagar());


Console.WriteLine("\nEladók összára:");
Console.WriteLine(iroda.EladokOsszara());


Console.WriteLine("\nKiadók átlag szobaszáma:");
Console.WriteLine(iroda.KiadokAtlagSzobaszama());


Console.WriteLine("\nLegolcsóbb 3:");
foreach (var x in iroda.Legolcsobb(3))
{
    Console.WriteLine(x.Ar);
}


Console.WriteLine("\n1. oldal:");
foreach (var x in iroda.Lapoz(1))
{
    Console.WriteLine(x.Telepules);
}


Console.WriteLine("\nEgyedi városok:");
foreach (var x in iroda.EgyediVarosnevek())
{
    Console.WriteLine(x);
}


Console.WriteLine("\nKülönböző szobaszámok:");
Console.WriteLine(iroda.KulonbozoSzobaszamok());


Console.WriteLine("\nVan olcsó m² ár?");
Console.WriteLine(iroda.VanOthonStart());


Console.WriteLine("\nSzerepel Budapest?");
Console.WriteLine(iroda.SzerepelTelepules("Budapest"));


Console.WriteLine("\nVan nagy kertes eladó?");
Console.WriteLine(iroda.VanNagyKertesEladoIngatlan());