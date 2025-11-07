//deklaráció
int[] szamok;
string[] szovegek;
char[] betuk;

//inicializálni (kedzeti értékadás)

//literállal
szamok = new int[5];

//változóval
int méret = 10;
szovegek = new string[méret];

//értékek felsorolásával
betuk = ['a', 'b', 'c'];

//tömbök tulajdonságia & metódusai

int hossza = betuk.Length;

//értékek elérése indexeléssel

int elso = 0;
int vége = -1;

char egyik = betuk[0];
char masik = betuk[elso];

char a = betuk.First();
char z = betuk.Last();