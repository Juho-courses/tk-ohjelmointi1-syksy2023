void TulostaSanaNKertaa(string sana, int n)
{
    for (int i = 0; i < n; i++)
    {
        Console.Write(sana);
    }
    Console.WriteLine();
}

// TulostaSanaNKertaa("moi", 2);
// TulostaSanaNKertaa("terve", 12);
// TulostaSanaNKertaa("SAMK", 1);


int PalautaMerkkijonoPituus(string sana)
{
    return sana.Length;
}

int pituus = PalautaMerkkijonoPituus("moro");
// TulostaSanaNKertaa(pituus.ToString(), 1);

bool OnkoYhtaIsot(int a, int b)
{
    if (a == b)
    {
        return true;
    }
    return false;
}

// Console.WriteLine(OnkoYhtaIsot(12, 12));
// Console.WriteLine(OnkoYhtaIsot(12, 13));

string TulostaSana()
{
    string sana = "moi";
    Console.WriteLine(sana);
    return sana;
}

string sana = TulostaSana();

