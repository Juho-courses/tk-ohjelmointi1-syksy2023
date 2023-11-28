// . Kirjoita funktio joka ottaa vastaan kaksi kokonaislukuargumenttia ja
// palauttaa niiden kertolaskun tuloksen.
// • ET saa käyttää kertolasku-operaatiota (*)
// • Ei tarvitse käsitellä negatiivisia lukuja

int Kertolasku(int a, int b)
{
    int tulo = 0;
    // toimii negatiivisilla luvuilla, jos a < 0 ja b > 0
    for (int i = 0; i < b; i++)
    {
        tulo += a;
    }
    return tulo;
}

Console.WriteLine(Kertolasku(4, 5) + " pitäisi olla 20");
Console.WriteLine(Kertolasku(5, 4) + " pitäisi olla 20");
Console.WriteLine(Kertolasku(0, 10) + " pitäisi olla 0");
Console.WriteLine(Kertolasku(10, 0) + " pitäisi olla 0");
Console.WriteLine(Kertolasku(16, 8) + " pitäisi olla 128");

Console.WriteLine(Kertolasku(-16, 8) + " pitäisi olla -128");
Console.WriteLine(Kertolasku(-10, 2) + " pitäisi olla -20");