// Luo funktio, joka ottaa vastaan argumenttina arrayn ja tulostaa sen arvot
// omille riveilleen.

void TulostaIntArray(int[] ints)
{
    foreach (int luku in ints)
    {
        Console.WriteLine(luku);
    }
}

int[] luvut = { 1, 2, 3, 4 };
TulostaIntArray(luvut);
TulostaIntArray([123, 31, 23, 123, 029293, 233]);