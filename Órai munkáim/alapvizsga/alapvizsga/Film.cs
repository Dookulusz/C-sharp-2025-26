//egyszerű fájlfeldolgozás
//osztály bevezetése
class Film
{
    //nyílvános mezők
    public string Title;
    public int Year;
    public double Rating;

    //konstuktor snipplet (ctor tab tab)
    public Film()
    {
        //csak egy példa
    }

    //Konstruktor generálása
    public Film(string title, int year, double rating)
    {
        Title = title;
        Year = year;
        Rating = rating;
    }

    //lehet többféle kontruktor isa praktikum kedvéért
    public Film(string sor)
    {
        //feldaraboljuk pontosbesszők mentén

        string[] darabok = sor.Split(';');

        //string[] darabok ["A hihetelen Hulk", "2008", "6.7"]
        Title = darabok[0];
        Year = int.Parse(darabok[1]);
        Rating = double.Parse(darabok[2]);
    }

    public bool IsRotten()
    {
        return Rating < 6.5;
    }

    public bool IsFresh()
    {
        return ! IsRotten();
    }
}

