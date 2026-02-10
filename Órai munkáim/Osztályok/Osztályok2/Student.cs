namespace Osztályok2;

//osztály definíciója
internal class Student
{
    //nyílvános mezők (field)
    public string Name;
    public int Year;
    public char Code;
    public bool Tech;

    //rejett adatok (nem írható, nem olvasható)
    private string Password;

    public Student(string name, int year, char code, bool tech)
    {
        Name = name;
        Year = year;
        Code = code;
        Tech = tech;
    }

    //konstruktorok (inicializáló függvény)

}
