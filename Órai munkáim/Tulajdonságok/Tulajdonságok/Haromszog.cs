class Haromszog
{
    //mezők (field)
    private int a;
    private int b;
    private int c;

    public Haromszog(int a, int b, int c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }

    // egy möködő, de kényelmetlen megoldás
    //hogy írunk egy függvényt az eléréshez
    public int GetA()
    { 
        return a;
    }

    public void SetA(int value)
    {
        a = value;
    }

    //mivel ilyet gyakran e csinálni
    //váltoóban is sok lehe osztályonként
    //praktikus lenne ezt tömríteni

    public int B
    {
        get
        {
            return b;
        }

        set
        {
            b = value;
        }
    }

    //írható tömörebben, hiszen a tördelés
    //c# ban csak az olvashatóság miatt van

    public int C
    {
        get { return c; }
        set { c = value; }
    }

    //modern megközelítésnek
    //ez még mindig nagyon terjengős

    private int terulet;

    public int Terulet
    {
        get => terulet;
        set => terulet = value;
    }

    // még egyszerübben (auto property)
    public int Kerulet { get; set; }
}

class Peldak
{
    int _a;
    int _b;
    int _c;

    public Peldak(int a, int b, int c)
    {
        A = a;
        B = b;
        C = c;
    }

    public int Kerulet
    {
        get => A + B + C;
    }

    public int A { get => _a; set => _a = value; }
    public int B { get => _b; set => _b = value; }
    public int C { get => _c; set => _c = value; }
}

class Masik
{
    //prop tab tab

    public int A { get; set; }
    public int B { get; set; }
    public int C { get; set; }

    //propfull tab tab
    private double kerulet;

    public double Kerulet
    {
        get { return kerulet; }
        set { kerulet = value; }
    }

    private double terulet;

    public double Terulet
    {
        get { return terulet; }
        set { terulet = value; }
    }

}