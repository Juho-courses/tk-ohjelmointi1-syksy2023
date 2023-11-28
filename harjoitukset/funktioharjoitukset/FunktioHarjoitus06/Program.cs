// Kirjoita funktio, joka laskee argumenttina saatavan kokonaislukutaulukon 
// jäsenten summan ja tulostaa lasketun summan
// • LaskeSumma([1,2,3]) tulostaa 6

int LaskeSumma(int[] arr)
{
    // return arr.Sum();

    int sum = 0;
    foreach (var item in arr)
    {
        sum += item;
    }
    return sum;
}

Console.WriteLine(LaskeSumma(new int[] { 1, 2, 3 }));