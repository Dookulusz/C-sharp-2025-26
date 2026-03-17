//feldolgozas

//1. Összár

// 2. szilardak szama


//3. Legolcsóbb

class Megrendeles
{
    public List<Vegyszer> termekek { get; set; }

    public Megrendeles()
    {
        termekek = [];
    }

    public int Termekszam()
    {
        return termekek.Count();
    }

    public void Import(string[] sorok)
    {
        termekek = sorok.Select(sor => new Vegyszer(sor)).ToList();
    }

    public double Fizetendo()
    {
        return termekek.Sum(x => x.Fizetendo);
    }
    
    public int Szilardakszama()
    {
        return termekek.Count(x => x.Szilard);
    }

    public Vegyszer Legolcsobb()
    {
        int minprice = termekek.Min(x => x.NettoAr);

        return termekek.First(x => x.NettoAr.Equals(minprice)); 
    }
}
        



