//kezdeti befektetés
double egyenleg = 1000;

//kitűzött cél
double plafon = 1_000_000;

//éves kanat 20%
double kamat = 1.2;

int év = 0;


//kérdés: hány év alatt érem el?
do
{
    egyenleg = egyenleg * kamat;
    év++;
}
while (plafon >= egyenleg);

Console.WriteLine($"{év} év alatt éri el.");