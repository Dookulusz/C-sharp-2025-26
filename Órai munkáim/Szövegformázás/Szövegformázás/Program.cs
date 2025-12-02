//Dookusz módszere
string eredeti = "daniel.doka22@gmail.com";
string maszkol = "";
int szamol = 0;


//meghatározzuk a @ helyét
for (int i = 0; i < eredeti.Length; i++)
{
    szamol++;

    char d = '@';

    if (eredeti[i] == d)
    {
        break;
    }

}

//kitakarjuk az e-mail cím első három karakterétől a @-ig
for (int i = 0; i < eredeti.Length; i++)
{
    char c = eredeti[i];

    if (i >= 3 && c != '@' && i < szamol)
    {
        c = '#';
    }

    maszkol += c;
}

Console.WriteLine(maszkol);