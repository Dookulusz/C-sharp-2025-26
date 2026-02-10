//példányosítás

using Osztályok2;

Student peldany = new("Dániel", 11, 'C', true);

Console.WriteLine(peldany.Year);

//másik megközelítés

var vezeteknev = "Dóka";
var keresztnev = "Dániel";
var tanterem = 63;

Teacher tanar = new (vezeteknev, keresztnev, tanterem);
