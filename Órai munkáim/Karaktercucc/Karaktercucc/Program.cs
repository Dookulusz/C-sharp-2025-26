int Szam(int a, int b)
{
    Random random = new Random();

    int veletlen = random.Next(a, b);

    return veletlen;
}


char Kisbetu()
{
    int szamos = Szam('a', 'z');
    return (char)szamos;
}
Console.WriteLine(Kisbetu());

char Nagybetu()
{
    int szamos = Szam('A', 'Z');
    return (char)szamos;
}
Console.WriteLine(Nagybetu());

string Szöveg(int a)
{
    string szoveg = "";

    for (int i = 1; i < a; i++)
    {   
        if (i == 1)
        {
            char c = Nagybetu();
            szoveg += c;
        }

        char d = Kisbetu();
        szoveg += d;
    }
    return szoveg;
}
Console.Write("Milyen hosszú legyen a szöveg: ");
int meddig = int.Parse(Console.ReadLine());

Console.WriteLine(Szöveg(meddig));

string Erosjelszo(int a)
{
    string jelszo = "";

    for (int i = 0; i < a; i++)
    {
        int szam = Szam(1,11);

        if (szam < 3)
        {
            jelszo += Kisbetu();
        }
        else if (szam < 6)
        {
            jelszo += Nagybetu();
        }
        else
        {
            jelszo += Szam(0, 10);
        }
    }
    return jelszo;
}

Console.Write("Milyen hosszú legyen a jelszavad?: ");
int jelszohossz = int.Parse(Console.ReadLine());

Console.WriteLine($"Az erős jelszavad: {Erosjelszo(jelszohossz)}");