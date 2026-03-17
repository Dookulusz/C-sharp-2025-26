class Etlap
{
    public List<Suti> Kinalat { get; set; }
    //üres étlap
    public Etlap()
    {
        Kinalat = [];
    }

    public Etlap(string[] sorok)
    {
        Kinalat = [];

        foreach (var item in sorok)
        {
            Suti peldany = new(item);
            Kinalat.Add(peldany);
        }
    }

    public Suti Napiajanlat()
    {
        Random random = new();

        int i = random.Next(0,Kinalat.Count());

        return Kinalat[i];
    }

    public int Osszar(string keresett)
    {
        int osszeg = 0;

        return osszeg;
    }

    public int Dijazott()
    {
        int darab = 0;

        return darab;
    }
}
