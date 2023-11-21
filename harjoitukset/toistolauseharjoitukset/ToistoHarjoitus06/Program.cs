// tarkistetaan kaikki luvut
for (int luku = 0; luku < 101; luku++)
{
    if (luku % 16 == 0)
    {
        Console.WriteLine(luku);
    }
}

// luodaan kaikki 16 jaolliset luvut
for (int luku = 0; luku < 101; luku += 16)
{
    Console.WriteLine(luku);
}