class Erotin
{
    // Erotin juttu = new Erotin('*', 5)
    // juttu.Piirra()
    // *****
    // public char Merkki { get; private set; }
    // public int Pituus { get; private set; }
    char merkki;
    int pituus;


    public Erotin(char _char, int len)
    {
        merkki = _char;
        pituus = len;
    }

    public int HaePituus()
    {
        return pituus;
    }

    public void Piirra()
    {
        // MerkkiMerkkiMerkkiMerkki...n
        // for (int i = 0; i < pituus; i++)
        // {
        //     Console.Write(merkki);
        // }
        int piirretyt_merkit = 0;
        while (piirretyt_merkit < pituus)
        {
            Console.Write(merkki);
            piirretyt_merkit += 1;
        }
        Console.WriteLine();
    }
}