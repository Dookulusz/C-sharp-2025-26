string magánhangzók = "aáeéoóuúiíöőüű";
string mássalhangók = "qwrtzpsdfghjklyxcvbnm";
string eredeti = "Tudsz így beszélni?";
string hablagy = "tuvudsz ivigy bevesévélnivi?";

/* SZABÁLY
 * Járjuk körbe az eredeti szöveget beűnkét
 * 
 *      Füzzök hozzá a hablatyhoz
 *      
 *      Vizsgáljuk meg, hogy magánhangzó-e?
 *      
 *          Ha igen, akkor ismételjük meg egy V betűvel
 *      
 *      Elágazás vége
 *      
 */

foreach (char betu in eredeti)
{
    if (magánhangzók.Contains(betu))
    {
        Console.WriteLine(betu + "\nv");
        Console.WriteLine(betu);
    }
    else
    {
        Console.WriteLine(betu);
    }
}