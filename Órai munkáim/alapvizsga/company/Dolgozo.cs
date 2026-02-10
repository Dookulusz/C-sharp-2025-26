class Dolgozo
{
    public string Nev;
    public int Kor;
    public int Fizetes;
    public string Beosztas;


    public Dolgozo(string nev, int kor, int fizetes, string beosztas)
    {
        Nev = nev;
        Kor = kor;
        Fizetes = fizetes;
        Beosztas = beosztas;
    }

    public Dolgozo(string sor)
    {
        string[] darabok = sor.Split(';');

        Nev = darabok[0];
        Kor = int.Parse(darabok[1]);
        Fizetes = int.Parse(darabok[2]);
        Beosztas = darabok[3];
    }

    public double NettoBer()
    {
        if (Kor <= 25)
        {
            int ado = Fizetes / 100 * 18;
            Fizetes -= ado;
        }
        else
        {
            int ado = Fizetes / 100 * 33;
            Fizetes -= ado;
        }
        return Fizetes;

    }
}

