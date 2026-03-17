class Suti
{
    public Suti(string nev, string type, bool dijazott, int ar, string kiszereles)
    {
        Nev = nev;
        Type = type;
        Dijazott = dijazott;
        Ar = ar;
        Kiszereles = kiszereles;
    }

    public string Nev { get; set; }
    public string Type { get; set; }
    public bool Dijazott { get; set; }
    public int Ar { get; set; }
    public string Kiszereles { get; set; }

    public Suti(string sor, char karakter = ';')
    {
        var darabok = sor.Split(karakter);

        Nev = darabok[0];
        Type = darabok[1];
        Dijazott = bool.Parse(darabok[2]);
        Ar = int.Parse(darabok[3]);
        Kiszereles = darabok[4];
    }

}