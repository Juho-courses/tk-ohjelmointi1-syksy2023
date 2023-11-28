// Kirjoita ohjelma joka tulostaa kertotaulut luvuille 1, 2 ja 3. Jokainen
// operaatio tulostetaan omalle rivilleen.
// • Yksi rivi outputissa: "2 * 3 = 6”

void Kertotaulu(int n)
{
    for (int i = 1; i <= 10; i++)
    {
        Console.WriteLine($"{n} * {i} = {n * i}");
    }
}

Kertotaulu(1);
Kertotaulu(2);
Kertotaulu(3);
