using System.Reflection.Metadata;

Console.WriteLine("Hello, World!");

Haromszog teszt = new (3,4,5);

int a = teszt.GetA();

Console.WriteLine("A oldal");
Console.WriteLine(a);

teszt.SetA(10);

/*Property*/

Console.WriteLine(teszt.B);
teszt.B = 20;


/******************/

teszt.C = 30;
teszt.Terulet = 40;
teszt.Kerulet = 50;

string username = "Dookusz";
string password = "Umszki2026";
string email = "dokadani@gmail.com";

User valaki = new User(username, password, email);

Haladobb masik = new Haladobb()
{
	Email = "email"
};

class Haladobb
{
	//rejtett mező (osztályon belül írható)
	private string password;

	//nyílvános olvasható jellemző
	public string Password
	{
		get { return password; }
	}

	//rövidebb alakban ugyanez
	public string Username { get; private set; }

	//csak egyszer beállítható jelemző
	public string Email { get; init; }
}