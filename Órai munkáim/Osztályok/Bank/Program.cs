var tulajdonos = "Dookusz";
var egyenleg = 1000;

Bankszamla otp = new Bankszamla(tulajdonos, egyenleg);

Console.WriteLine("ő a tulajdonos");
Console.WriteLine(otp.tulajdonos);
Console.WriteLine();

Console.WriteLine("Ennyi pénze van");
Console.WriteLine(otp.Egyenleglekérdezés());
Console.WriteLine();

Console.WriteLine("Teszt túl sok pénzre");
otp.Pénzfelvétel(99999999);
Console.WriteLine(otp.Egyenleglekérdezés());
Console.WriteLine();

Console.WriteLine("teszt helyes értékre (változnia kell)");
otp.Pénzfelvétel(999);
Console.WriteLine(otp.Egyenleglekérdezés());
Console.WriteLine();
