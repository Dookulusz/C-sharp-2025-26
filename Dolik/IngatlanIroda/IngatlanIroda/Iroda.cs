using System.Text;


/// <summary>
/// Az ingatlanirodai hirdetéseit kezelő osztály
/// </summary>
class Iroda
{
    /// <summary>
    /// Konstruktor
    /// </summary>
    private Iroda()
    {
        hirdetesek = [];
    }

    /// <summary>
    /// Az ingatlanok adait
    /// </summary>
    public List<Ingatlan> hirdetesek;

    /// <summary>
    /// Visszaadja a hirdetések aktuális számát
    /// </summary>
    public int IngatlanokSzama => hirdetesek.Count;

    /// <summary>
    /// Feldolgozza egy CSV fájl tartalmát
    /// </summary>
    public static Iroda Parse(string[] sorok, bool vanFejlec = true, char elvalaszto = ';')
    {

        Iroda iroda = new Iroda();

        foreach (var item in sorok.Skip(1))
        {
            Ingatlan uj = Ingatlan.Parse(item);
            iroda.hirdetesek.Add(uj);

        }

        return iroda;

    }

    /// <summary>
    /// Visszaadja az összes eladó (nem kiadó) ingatlant.
    /// </summary>
    public List<Ingatlan> EladoIngatlanok()
    {
        return hirdetesek.Where(x => x.Eladoe.Equals(true)).ToList();
    }

    /// <summary>
    /// Visszaadja azokat az ingatlanokat, amelyek alapterülete meghaladja a keresett m²-t.
    /// </summary>
    public List<Ingatlan> NagyobbAlapteruletMint(int kuszob)
    {
        return hirdetesek.Where(x => x.Terulet > kuszob).ToList();
    }

    /// <summary>
    /// Visszaadja a keresett városból az olyan az ingatlanokat, amelyek ára a küszöbb alatti.
    /// </summary>
    public List<Ingatlan> OlcsobbAdottTelepulesen(int plafon, string telepules)
    {
        return hirdetesek.Where(x => x.Telepules == telepules && x.Ar < plafon).ToList();
    }

    /// <summary>
    /// Visszaadja az összes földszintes (Emelet == 0) ingatlant.
    /// </summary>
    /// <remarks>Mi ilyenkor a további "teendőnk"?</remarks>
    public List<Ingatlan> FoldszintesIngatlanok()
    {
        return hirdetesek.Where(x => x.Emelet == 0).ToList();
    }

    /// <summary>
    /// Visszaadja az ingatlanokat ár szerint növekvő sorrendbe rendezve.
    /// </summary>
    public List<Ingatlan> ArSzerintNovekvo()
    {
        return hirdetesek.OrderBy(x => x.Ar).ToList();
    }

    /// <summary>
    /// Visszaadja az ingatlanokat alapterület szerint csökkenő sorrendbe rendezve.
    /// </summary>
    public List<Ingatlan> AlapteruletCsokkeno()
    {
        return hirdetesek.OrderByDescending(x => x.Terulet).ToList();
    }

    /// <summary>
    /// Visszaadja az adott település ingatlanjait szobaszám szerint csökkenő sorrendbe rendezve.
    /// </summary>
    public List<Ingatlan> SzobaSzerintCsokkeno(string telepules)
    {
        return hirdetesek.OrderByDescending(x => x.Szobak).ToList();
    }

    /// <summary>
    /// Visszaadja az hirdetesek alapterületét formázott szövegként "73.5 m²"
    /// </summary>
    public List<string> Alapteruletek()
    {
        return hirdetesek.Select(x => x.Terulet.ToString() + " m²").ToList();
    }

    /// <summary>
    /// Visszaadja az hirdetesek négyzetméterárát (100 millió / 100 m² => 1 millió/m²).
    /// </summary>
    /// <remarks>Mi ilyenkor a további "teendőnk"?</remarks>
    public List<double> NegyzetmeterArak()
    {
        return hirdetesek.Select(x => x.Ar / x.Terulet).ToList();
    }

    /// <summary>
    /// Visszaadja az összes ingatlan átlagos árát (millió Ft-ban).
    /// </summary>
    public double Atlagar()
    {
        return hirdetesek.Average(x => x.Ar);
    }

    /// <summary>
    /// Visszaadja az összes eladó ingatlan árainak összegét (millió Ft-ban).
    /// </summary>
    public double EladokOsszara()
    {
        return hirdetesek.Sum(x => x.Ar);
    }

    /// <summary>
    /// Visszaadja a kiadó hirdetesek átlagos szobaszámát.
    /// </summary>
    public double KiadokAtlagSzobaszama()
    {
        return hirdetesek.Average(x => x.Szobak);
    }

    /// <summary>
    /// Visszaadja az első X darab legolcsóbb ingatlant ár szerint rendezve.
    /// </summary>
    public List<Ingatlan> Legolcsobb(int darab)
    {
        return hirdetesek.OrderBy(x => x.Ar).Take(darab).ToList();
    }

    /// <summary>
    /// Egy weboldalon 10 darab ingatlan adatait szeretnénk megjeleníteni egyszerre.
    /// A felhasználó lapozgathat az oldalak között. Visszaadja az aktuális oldal tartalmát.
    /// </summary>
    public List<Ingatlan> Lapoz(int oldal)
    {
        return hirdetesek.Skip((oldal - 1) * 10).Take(10).ToList();
    }

    /// <summary>
    /// Visszaadja az összes egyedi városnevet, amelyben van ingatlan.
    /// </summary>
    public List<string> EgyediVarosnevek()
    {
        return hirdetesek.Select(x => x.Telepules).Distinct().ToList();
    }

    /// <summary>
    /// Visszaadja, hány különböző szobaszám-érték fordul elő az adatbázisban.
    /// Például 1 szobás, 1.5 szobás és 2 szobás hirdetesek esetén a 3-at.
    /// </summary>
    public int KulonbozoSzobaszamok()
    {
        return hirdetesek.Select(x => x.Szobak).Distinct().Count();
    }

    /// <summary>
    /// Igaz-e, hogy van olyan ingatlan, amelynek négyzetméterára 1.5 millió forint alatti?
    /// </summary>
    public bool VanOthonStart()
    {
        return hirdetesek.Any(x => (x.Ar / x.Terulet) < 1.5);
    }

    /// <summary>
    /// Szerepel-e a városok között keresett település?
    /// </summary>
    public bool SzerepelTelepules(string keresett)
    {
        return hirdetesek.Exists(x => x.Telepules.Equals(keresett));
    }

    /// <summary>
    /// Van-e olyan kertes és eladó ingatlan, amelynek alapterülete meghaladja a 100 m²-t?
    /// </summary>
    public bool VanNagyKertesEladoIngatlan()
    {
        return hirdetesek.Exists(x => x.Terulet > 100);
    }
}
