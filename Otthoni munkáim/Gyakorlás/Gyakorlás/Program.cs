//1. projekt
//Kis-Nagy betű konvertálás
string cucc = Console.ReadLine();

char[] tomb = cucc.ToCharArray();
string[] changedarray = new string[tomb.Length];
int counter = 0;

foreach  (char c in tomb)
{
    char d = c;

    if (char.IsUpper(c))
    {
        d = char.ToLower(c);
    }
    else if (char.IsLower(c))
    {
        d = char.ToUpper(c);
    }

    changedarray[counter] = d.ToString();
    counter++;
}

foreach (var item in changedarray)
{
    Console.Write(item);
}