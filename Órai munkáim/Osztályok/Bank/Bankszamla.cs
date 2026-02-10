//osztálydefiníció
internal class Bankszamla
{
    //nyílvános mező
    public string tulajdonos;

    //rejtette mező
    private int egyenleg;

    //konstruktor
    public Bankszamla(string tulajdonos, int egyenleg)
    {
        this.tulajdonos = tulajdonos;
        this.egyenleg = egyenleg;
    }

    //működst leíró függvények
    public int Egyenleglekérdezés()
    {
        return egyenleg;
    }

    public bool VanFedezet(int összeg)
    {
        if (egyenleg >= összeg)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void Pénzfelvétel(int összeg)
    {
        if (VanFedezet(összeg))
        {
            egyenleg -= összeg;
        }
        else
        {
            Console.WriteLine("Hibás tranzakció");
        }
    }
}