//palya
int hossz = 70;
int magassag = 20;

//játék háttere
Console.BackgroundColor = ConsoleColor.Black;
Console.ForegroundColor = ConsoleColor.Yellow;
Console.Clear();

Console.WindowHeight = magassag;
Console.WindowWidth = hossz;

//ne látszódjon a cursor helye
Console.CursorVisible = false;

//karakter
int sor = 0;
int oszlop = 0;

string karakterem =
    """
    (O.O)
    """;

Console.Write(karakterem);

var gomb = Console.ReadKey();
