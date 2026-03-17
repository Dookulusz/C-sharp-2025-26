//feldolgozás inditása

//kérdések teszt




class Student
{
    //adatmezők
    public string Firstname { get; set; }
    public string LastName { get; set; }
    public int Identifier { get; set; }
    public int Room { get; set; }

    //pontszámok tárolása
    List<int> Points { get; set; }

    //néhány példa számított értékekre
    public int TotalScore => Points.Sum();

    //minden kérdésre vákaszolt?
    public bool AnswerAllQuestions => Points.All(p => p > 0);

    //volt olyan kérdés amit skippelt?
    public bool MissedAnyQuesitons => Points.Any(p => p == 0);


    //néha szükség van egy üres konstruktorra is
    private Student()
    {
        
    }

    //gnerlált kontsruktor
    public Student(string firstname, string lastName, int identifier, int room)
    {
        Firstname = firstname;
        LastName = lastName;
        Identifier = identifier;
        Room = room;

        //a listát is példányosítani kell!
        Points = [];
    }

    //osztályszintű "szövegertelmező" metódus
    public static Student Parse(string content)
    {
        var darabok =  content.Split(';');

        // 1. opció kontruktorral
        Student egyik = new Student(
            darabok[0],
            darabok[1],
            int.Parse(darabok[2]),
            int.Parse(darabok[3]));

        //2. opció az üres konstruktorral
        Student masik = new Student();
        masik.Firstname = darabok[0];
        masik.LastName = darabok[1];
        masik.Identifier = int.Parse(darabok[2]);
        masik.Room = int.Parse(darabok[3]);

        //inicailizáló blokk
        Student harmadik = new Student()
        {
            Firstname = darabok[0],
            LastName = darabok[1],
            Identifier = int.Parse(darabok[2]),
            Room = int.Parse(darabok[3]),
            Points = darabok.Skip(4).Select(pont => int.Parse(pont)).ToList(),
        };

        return harmadik;
    }
}
