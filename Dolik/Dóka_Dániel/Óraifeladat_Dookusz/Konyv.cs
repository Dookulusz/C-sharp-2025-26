class Konyv
{
    private string cim;
    private string szerzo;
    private int oldalak_szama;
    private double ar;
    private bool kolcsonzott;

    public string Cim { get => cim; set => cim = value; }
    public string Szerzo { get => szerzo; set => szerzo = value; }
    public int Oldalak_szama { get => oldalak_szama; set => oldalak_szama = value; }
    public double Ar { get => ar; set => ar = value; }
    public bool Kolcsonzott { get => kolcsonzott; set => kolcsonzott = value; }

    public Konyv(string cim, string szerzo, int oldalak_szama, double ar, bool kolcsonzott)
    {
        this.cim = cim;
        this.szerzo = szerzo;
        this.oldalak_szama = oldalak_szama;
        this.ar = ar;
        this.kolcsonzott = kolcsonzott;
    }

    public Konyv()
    {

    }

    public Konyv(string tartalom)
    {
        string[] szovegvalaszt = tartalom.Split(";");

        cim = szovegvalaszt[0];
        szerzo = szovegvalaszt[1];
        oldalak_szama = int.Parse(szovegvalaszt[2]);
        ar = double.Parse(szovegvalaszt[3]);
        kolcsonzott = bool.Parse(szovegvalaszt[4]);
    }


    public string SzoveggeAlakit()
    {
        string alakitott = $"{szerzo} - {cim}";

        return alakitott;
    }

    public bool Allapotvaltas()
    {
        if (kolcsonzott == true)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
}

