//példányosítás

internal class Teacher
{
    private string vezeteknev;
    private string keresztnev;
    private int tanterem;

    public Teacher(string vezeteknev, string keresztnev, int tanterem)
    {
        this.vezeteknev = vezeteknev;
        this.keresztnev = keresztnev;
        this.tanterem = tanterem;
    }
}