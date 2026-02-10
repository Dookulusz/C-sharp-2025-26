//egyszerű fájlfeldolgozás
string[] sorok = File.ReadAllLines("marvel.csv");

// üres lista filmeknek
List<Film> marvel = [];

//járjuk gégig a dorokat és alakítsuk filmekké
foreach (string sor in sorok)
{
    //példányosítsuk
    Film uj = new Film(sor);

    //vegyük fel a listába
    marvel.Add(uj);
}

//tesztelésképpen írjuk ki a filmek címét
foreach (Film film in marvel)
{
    Console.WriteLine(film.Title);
}

List<string> szurt = [];


// minden elemet megviszgélunk
foreach (var item in marvel)
{

    //ha a feltétel megfelele
    if (item.IsRotten())
    {
        //felvesszük a másik listába
        szurt.Add(item.Title);
    }
}

//mentsük az eredményt fájlba
File.WriteAllLines("boooooooo.txt", szurt);