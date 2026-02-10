var name = "Dóka Dániel";
var year = 11;
var code = 'C';
var tech = true;

//osztály  példányosítása
Student egyik = new Student(name,year,code,tech);
var masik = new Student("Dóka Dániel", 11, 'C', true);

if (egyik == masik)
{
    Console.WriteLine("Igen, egyeznek");
}
else
{
    Console.WriteLine("Nem, nem egyeznem");
}

//osztály definíciója
record class  Student(string Name, int Year, char Code, bool Tech);