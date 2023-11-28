// Luo funktio, jolla on kaksi argumenttia: k(int) ja the_list(int[]). Funktio
// palauttaa kokonaisluvun, joka kertoo moniko the_list-arrayn jäsen on 
// arvoltaan suurempi tai yhtä suuri kuin k.
// • FilterNumbers(3, [1, 2, 3, 4, 5]) palauttaa kokonaisluvun 3
// • FilterNumbers(6, [1, 2, 3, 4, 5]) palauttaa kokonaisluvun 0

int FilterNumbers(int k, int[] luvut)
{
    int count = 0;

    foreach (var luku in luvut)
    {
        if (luku >= k)
        {
            count++;
        }
    }

    return count;
} // funktio loppuu

int[] luvut = { 1, 2, 3, 4, 5 };
int k = 3;
int maara = FilterNumbers(k, luvut);
Console.WriteLine(maara);

maara = FilterNumbers(6, luvut);
Console.WriteLine(maara);