// Kirjoita funktio joka palauttaa sille argumenttina annettavan
// kokonaislukuarrayn suurimman jäsenen
// • [1,3,4,5] palauttaa 5
// • [16,32,4,5] palauttaa 32

int PalautaSuurin(int[] arr)
{
    // yksinkertaisimmillaan
    // return arr.Max();

    int suurin = arr[0];
    foreach (var item in arr)
    {
        if (item > suurin)
        {
            suurin = item;
        }
    }
    return suurin;
}

Console.WriteLine(PalautaSuurin(new int[] { 1, 3, 5, 6 }));
Console.WriteLine(PalautaSuurin(new int[] { 16, 32, 4, 5 }));