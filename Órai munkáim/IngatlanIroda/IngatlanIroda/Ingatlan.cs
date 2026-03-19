using System.ComponentModel;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;

/// <summary>
/// Az ingatlan adatait tároló osztály.
/// </summary>
/// 
class Ingatlan
{

    public string Telepules { get; set; }
    public string Cim { get; set; }
    public double Terulet { get; set; }
    public int Szobak { get; set; }
    public double Ar { get; set; }
    public int Emelet { get; set; }
    public bool Eladoe { get; set; }
    public bool Kertese { get; set; }

    public static Ingatlan Parse(string sor)
    {
        var darabok = sor.Split(";");

        Ingatlan uj = new()
        {
            Telepules = darabok[0],
            Cim = darabok[1],
            Terulet = double.Parse(darabok[2]),
            Szobak = int.Parse(darabok[3]),
            Ar = double.Parse(darabok[4]),
            Emelet = int.Parse(darabok[5]),
            Eladoe = bool.Parse(darabok[6]),
            Kertese = bool.Parse(darabok[7]),
        };

        return uj;

    }
}