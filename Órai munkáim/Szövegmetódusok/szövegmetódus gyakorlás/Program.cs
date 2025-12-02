string angolAbc = "abcdefghijklmn opqrstuvwxyz";
string titokKod = "☺☻♥♦♣♠<>#&@{};=*łŁ$ß¤÷×§+!%";

string szoveg = Console.ReadLine();
string titkos = "";

foreach (var item in szoveg)
{
    int szam = angolAbc.IndexOf(item);
    titkos += titokKod[szam];
}

Console.WriteLine(titkos);

/* A törtelem során számos helyen, a modern korban leginkább
* iskolai játtékból kerül el a "Pigpen" / "Tic-Tac-Toe" titkosírás.
* https://en.wikipedia.org/wiki/Pigpen_cipher
*
* A lényege igazából annyi, hogy a jól ismert latin betűk helyett,
* valamilyen kitalált "nyelv" ABC készletével írjuk le a szöveget.
* 
* Aki nem tudja, hogy melyik betűt milyen jelnek feleltetünk meg,
* az szabad szemmel nem tudja kiolvasni a titkosírás szövegét.
* (Mintha a szövegszerkesztő betűtípusát "Wingdings"-re állítanánk.)
*
* Valósítsunk meg saját titkosírtást! Az egyszerűség kedvéért az
* angol ABC kisbetűit feletessük meg különleges ASCII karakternek.
*/
