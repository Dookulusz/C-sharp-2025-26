// Készítsen saját osztályt az adatok tárolásához!

using System.Runtime.ExceptionServices;
using System.Security.Principal;

class Szereplo
{
    /* JELLEMZŐK
     * 
     * Minden szereplőről ismertek az alábbi adatok:
     * - a színész neve           ("Peter Dinklage")
     * - a karakter neve          ("Tyrion Lannister")
     * - hány epizódban szerepelt (67)
     * - mikor szerepelt először  (2011)
     * - mikor szerepelt utoljára (2016) 
     */

    public string Nev { get; set; }
    public string KarakterNev { get; set; }
    public int Epizod { get; set; }
    public int MikorElso { get; set; }
    public int Mikorutolso { get; set; }
    public Szereplo(string nev, string karakterNev, int epizod, int mikorElso, int mikorutolso)
    {
        Nev = nev;
        KarakterNev = karakterNev;
        Epizod = epizod;
        MikorElso = mikorElso;
        Mikorutolso = mikorutolso;
    }


    /* KONSTRUKTOR
     * 
     * Készítsen konstruktort, ami egyetlen szöveget vár!
     * Azt feldarabolja pontosvessző karakterek mentén.
     * Ha kell, az egyes darabokat megfelelő típusra alakítja.
     * Ezekből állítja be az osztály adatait. 
     */
    public Szereplo(string sor)
    {
        
        var adatok = sor.Split(';').ToArray();

        Nev = adatok[0];
        KarakterNev = adatok[1];
        Epizod = int.Parse(adatok[2]);
        MikorElso = int.Parse(adatok[3]);
        Mikorutolso = int.Parse(adatok[4]);
    }





    /* ÉVADOK SZÁMA
     * 
     * Készítsen függvényt vagy tulajdonságot EvadokSzama azonosítóval,
     * ami kiszámolja, hány évadon keresztül szerepelt a sorozatban
     * Képlete: (Végzés éve - Kezdés éve) + 1 
     */

    public int EvadokSzama()
    {
        return (Mikorutolso - MikorElso) + 1;
    }



    /* ÁTLAGOS SZEREPLÉS
     * 
     * Készítsen függvényt vagy tulajdonságot AtlagosSzereples azonosítóval,
     * ami kiszámolja, hogy a szerepelő egy évadban átlagosan hányszort szerepelt.
     * Ehhez használja a fenti EvadokSzáma függvényt vagy tulajdonságot!
     * Képlete: Epizódok száma / EvadokSzama 
     */

    public int AtlagosSzereples()
    {
        return Epizod - EvadokSzama();
    }


}