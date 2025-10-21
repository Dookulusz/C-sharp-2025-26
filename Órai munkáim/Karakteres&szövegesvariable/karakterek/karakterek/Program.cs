//deklatároció

using System.Security.Cryptography.X509Certificates;

char karakter;

//értékadás literálként
//megadása aposztróffal
karakter = 'A';

//üres karakter megadása nem értelmezett!!!

//beolvasás
/*
karakter = Console.ReadKey().KeyChar;
*/

//fura dolgok
int minimum = char.MinValue;
int maximum = char.MaxValue;

Console.WriteLine("Minimum");
Console.WriteLine(minimum);

Console.WriteLine();

Console.WriteLine("Maximum");
Console.WriteLine(maximum);
Console.WriteLine();

//a karakter gyakorlatila egy szám
//ezek szerint át is lehet alakítani?
int egesz = 88;
karakter = (char)egesz;
Console.WriteLine($"Ez a karakter {karakter}");

//szövegből átalakítás
string szöveg = "a";
karakter = char.Parse(szöveg);

//így is lehet, de nem tanácsos mert régi mint a tök
/*
karakter = Convert.ToChar(karakter);
*/

//KARAKTERMŰVELETEK
karakter = char.ToUpper('x');
karakter = char.ToLower('X');

// nagybetűs?
char.IsUpper(karakter);

//kisbetűs?
char.IsLower(karakter);

//számjegyet írt be a felhasználó?
char.IsDigit(karakter);

//szimbólumot?
char.IsSymbol(karakter);


//NÉHÁNY FONTOS VEZÉRLŐ KARAKTER

char aposztrof = '\'';
char tablátor = '\t';
char sortores = '\n';
char backspace = '\\';
