using System.Reflection.Metadata.Ecma335;

string email = "daniel.doka@umszki.hu";
string maszk = "";

Console.WriteLine(email.IndexOf("umszki"));
Console.WriteLine(email.IndexOf('@'));

//szövegrészlet

Console.WriteLine("Részlet");
int honna = 6;
int hová = 7;
Console.WriteLine(email.Substring(6,7));

//baélra-jobbra-középre zárt
string szoveg = "pelda";
Console.WriteLine(szoveg);
Console.WriteLine(szoveg.PadLeft(10));
Console.WriteLine(szoveg.PadLeft(10, '-'));
Console.WriteLine(szoveg.PadRight(10));
Console.WriteLine(szoveg.PadRight(10,'-'));

// "dan"
var eleje = email.Substring(0, 3);

//12
var kukac = email.IndexOf('@');

// "@umszki.hu"
var vegen = email.Substring(kukac);

//eredmény
maszk = eleje.PadRight(kukac, '#') + vegen;
Console.WriteLine(maszk);

// csere
szoveg.Replace('a', 'b');
szoveg.Replace("abc", "def");

//törlés
szoveg.Replace("valami", "");

//kezedete
szoveg.StartsWith("daniel");

//vége
szoveg.EndsWith("umszki.hu");

//feldarabolás
string[] darabok = email.Split('@');

//összefűzés
email = string.Join('@', darabok);

string[] nevek = ["anita", "bence", "csaba"];
Console.WriteLine(string.Join(", ", nevek));