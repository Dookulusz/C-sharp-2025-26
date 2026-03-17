Student teszt = Student.Parse("Kovács;Péter;1632116;113;8;9;9;0;1;3;1;5;7");
Console.WriteLine(teszt.Firstname);
 //Beolvasás
var content = File.ReadAllLines("CLI_forras.csv");

//feldolgozás inditása
Exam proba = Exam.LordfromCsv(content);

//kérdések teszt
foreach (var item in proba.Topics)
{
    Console.WriteLine(item);
}
Console.WriteLine();

foreach (var item in proba.Students)
{
    Console.WriteLine(item.LastName);
}

Console.WriteLine("top 16");

foreach (var item in proba.TopStudents)
{
    Console.WriteLine($"{item.TotalScore} pont - {item.Firstname} {item.LastName}");
}
Console.WriteLine();

List<Student> successful = proba.Successful;


//kik azok a diákok akik sikeres felvételit tettek?
//sikeres => 40 pont vagy afelette

foreach (var item in successful)
{
    Console.WriteLine($"{item.TotalScore} pont - {item.Firstname} {item.LastName}");
}

class Exam
{
    public List<string> Topics { get; set; } = [];
    public List<Student> Students { get; set; } = [];

 
    private Exam()
    {
        
    }

    public static Exam LordfromCsv(string[] content)
    {
        //ne felejtsük el példányosítani
        Exam instance = new Exam();

        //a paraméter kapott szöveges sorokból
        instance.Topics = content
            //csak a fejléc
            .First()
            //feldarabolva
            .Split(";")
            //az első négy oszlop
            .Skip(4)
            //a többi kérdések listája
            .ToList();

        instance.Students = content
            //most a fejléc nem fog kelleni
            .Skip(1)
            //minden sorbol diákot kell készítenünk
            .Select(sor => Student.Parse(sor))
            //elméletileg mindent mást a diák intéz
            .ToList();

        return instance;
    }

    //minden feltvételin 40 pont a ponthatár
    public static int Passlimit = 40;

    public static int PersonLimit = 16;
    public List<Student> Successful => Students.Where(s => s.TotalScore > Passlimit).ToList();

    public List<Student> TopStudents => Students.
        OrderByDescending(s => s.TotalScore).
        Take(PersonLimit)
        .ToList();

    public List<Student> ABCStudents => Students
        .OrderByDescending(s => s.TotalScore)
        .ThenBy(s => s.LastName)
        .Take(PersonLimit)
        .ToList();
}
