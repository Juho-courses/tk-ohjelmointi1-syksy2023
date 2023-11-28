// .Käyttäen edellistä tehtävää hyödyksi, kirjoita funktio joka ottaa
// argumenttina vastaan tiedon isoimmasta tulostettavasta kertotaulusta ja
// tulostaa kertotaulut annettuun lukuun asti.
// • TeeKertotaulut(8) tulostaa kertotaulut luvuille 1,2,3,4,5,6,7 ja 8

void Kertotaulu(int n)
{
    for (int i = 1; i <= 10; i++)
    {
        Console.WriteLine($"{n} * {i} = {n * i}");
    }
}

void TeeKertotaulut(int n)
{
    for (int i = 1; i <= n; i++)
    {
        Kertotaulu(i);
    }
}

TeeKertotaulut(8);