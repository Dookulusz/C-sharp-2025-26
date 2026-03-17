class Vegyszer
{
    public string Megnevezes { get; set; }
    public int Kiszereles { get; set; }
    public string Egyseg { get; set; }
    public int NettoAr { get; set; }
    public int Mennyiseg { get; set; }

    public double Fizetendo => Mennyiseg * NettoAr * 1.27;

    public bool Szilard => Egyseg.Equals("g");


    public Vegyszer(string sor)
        {
        var darabok = sor.Split(';');

        Megnevezes = darabok[0];
        Kiszereles = int.Parse(darabok[1]);
        Egyseg = darabok[2];
        NettoAr = int.Parse(darabok[3]);
        Mennyiseg = int.Parse(darabok[4]);
        }
}