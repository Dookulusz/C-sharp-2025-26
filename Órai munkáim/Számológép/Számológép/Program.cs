// addig olvas be szövegeket a kkonzolról
// amíg a felhasználó nem ír be egy egész számot
int GetSafeInteger()
{
    string valasz;

    // ismételjük a beolvasást addig
    do
    {
        Console.Write("Adj meg egy pozitív egész számot: ");
        valasz = Console.ReadLine();
    }
    // amíg nem csak számjegyeket tartalmaz
    while (! ContainsOnlyDigits(valasz));

    // ha a határozatlan ciklus véget ér
    // akkor a válasz változóban biztosan
    // csak számjegyek szerepelnek
    int eredmény = int.Parse(valasz);

    // visszaadjuk a hívónak
    return eredmény;
}

// egy szövegről eldönti, hogy tartalmaz-e nem számjegyet
// (0,1,2,3,4,5,6,7,8,9 karaktertől eltérő betűt vagy írásjelet)
bool ContainsNoDigit(string szoveg)
{
    return false;
}

//egy szövegről eldönti, hogy csak számjegyekből áll-e
bool ContainsOnlyDigits(string szoveg)
{
    //az üres szöveg biztosan nem szám
    if (szoveg.Length == 0)
    {
        return false;
    }

    //járjuk végig a betűket
    foreach (char betu in szoveg)
    {
        //ha ez NEM egy számjegy
        if ( ! char.IsDigit(betu))
        {
            return false;
        }
    }

    //ha a ciklus lefutott, akkor nem léptünk be
    //az elágazásba, nem volt return utasítás
    //tehát ide csak akkor kerülhet a kód futása
    //ha a szövegben minden betű számjegy volt
    return true;
}

// egy matematikai műveletei jelet ad vissza
// előre meghatározott értékek közül
string GetValidOperator(string accepted)
{
    string muvelet;

    do
    {
        Console.Write("Műveleti jel? ");
        muvelet = Console.ReadLine(); 
    }
    // amíg NEM az elfogadott műveletek közül választ
    while (IsValidOperation());

    return muvelet;
}

bool IsValidOperation()
{
    return true; 
}

//adatok
int egyik = GetSafeInteger();
int masik = GetSafeInteger();
string muvelet = GetValidOperator("+-*/%");

//számítás
int eredmeny = DoCalculation(egyik, masik, muvelet);

//kiiratás
Console.WriteLine($"{egyik} {muvelet} {masik} = {eredmeny}");

static int DoCalculation(int egyik, int masik, string muvelet)
{
    if (muvelet == "+")
    {
        return egyik + masik;
    }
    if (muvelet == "-")
    {
        return egyik - masik;
    }
    if (muvelet == "*")
    {
        return egyik * masik;
    }
    if (muvelet == "/")
    {
        return egyik / masik;
    }
    if (muvelet == "%")
    {
        return egyik % masik;
    }
    return 0;

    //tömörebben is írható

    return muvelet switch
    {
        "+" => egyik + masik,
        "-" => egyik - masik,
        "*" => egyik * masik,
        "/" => egyik / masik,
        "%" => egyik % masik,
    };
}

//adjuk össze két számot
int Osszeg(int a, int b)
{
    int eredmény = a + b;

    return eredmény;
}

//vonjuk ki a két számot
int Kulonbseg(int a, int b)
{
    int eredmény = a - b;

    return eredmeny;
}

//két egész szám szorzatát de ne használjunk hozzá szorzás operátort
//hiszen megoldható isméltelgetett összeadással
int Szorzat(int szorzo, int szorzando)
{
    int eredmeny = 0;

    // ismételgetett összeadás
    for (int i = 0; szorzo > i; i++)
    {
        //összeadás
        eredmeny += szorzando;
    }

        return eredmeny;
}

Szorzat(5, 3);

//két szám hatványa
//két szám hatványa nem negatív hatványa
int Hatvány(int alap, int kitevo)
{
    // valami a "nulladikon" az 1
    int eredmeny = 1;

    //ismételgetett
    for (int i = 0; i < kitevo; i++)
    {
        // szorozgatás
        eredmeny += alap;
    }

    return eredmeny;
}
Hatvány(2, 10);

//két szám osztásának egész része
int OsztasEgeszResze(int szamlalo, int nevezo)
{
    int hanyados = 0;

    //számláló nevező maradék hányados
    //  10    -  3   =   7       1x
    //   7    -  3   =   4       2x
    //   4    -  3   =   1       3x
    //   1      ciklus megáll

    while (szamlalo >= nevezo)
    {
        //számláló csökken
        szamlalo -= nevezo;

        //sikerek száma nő
        hanyados++;

    }
    return hanyados;
}

OsztasEgeszResze(10, 3);

//két szám osztásának maradéka
int OsztasMaradeka(int szamlalo, int nevezo)
{
    while (szamlalo>= nevezo)
    {
        szamlalo -= nevezo;
    }

    //ciklus után ami marad belőle, az a maradék
    return szamlalo;
}
OsztasMaradeka(10, 3);

//két szám közül melyik a kisebb?

int Nagyobb(int a, int b)
{
    int nagyi;

    if (a > b)
    {
        nagyi = a;
    }
    else
    {
        nagyi = b;
    }
    return nagyi;
}
Nagyobb(1, 2);

//két szám közül melyik a nagyobb?
int Kisebb(int a, int b)
{
    int kicsi;

    if (a < b)
    {
        kicsi = a;
    }
    else
    {
        kicsi = b;
    }
    return kicsi;
}
Kisebb(1, 2);
