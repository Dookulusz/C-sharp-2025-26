string[] tartalom = File.ReadAllLines("dolgozok.csv");

List<Dolgozo> dolgozo = [];


foreach (var item in tartalom.Skip(1))
{
    Dolgozo uj = new Dolgozo(item);
    dolgozo.Add(uj);
}

Console.WriteLine("Add meg az életkorod");
int eletkor = int.Parse(Console.ReadLine());

while (eletkor < 16 && eletkor > 65)
{
    Console.WriteLine("Add meg az életkorod");
    eletkor = int.Parse(Console.ReadLine());
}

List<string> szurt = [];

foreach (var item in dolgozo)
{
    if (eletkor > item.Kor)
    {
        szurt.Add(item.Nev);
    }
}

File.WriteAllLines("DolgozoNeve.txt", szurt);
