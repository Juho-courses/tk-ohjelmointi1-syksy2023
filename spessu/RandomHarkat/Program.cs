// Kirjoita ohjelma, joka tulostaa yhden satunnaisen kokonaisluvun nollan
// (0) ja sadan (100) väliltä.

Random r = new Random();

void TulostaRandomLuku()
{
    Console.WriteLine(r.Next(0, 100));
}

// TulostaRandomLuku();

// Kirjoita ohjelma, joka kysyy käyttäjältä kahta positiivista lukua. Jos 
// epäkelvot numerot, lopeta ohjelman suoritus. Jos luvut OK, arvo
// satunnainen kokonaisluku annettujen numeroiden väliltä ja tulosta se
void Harjoitus2()
{
    try
    {
        Console.Write("anna positiivinen luku:");
        int luku1 = int.Parse(Console.ReadLine());

        Console.Write("anna positiivinen luku:");
        int luku2 = int.Parse(Console.ReadLine());

        // int asd = luku1 / luku2;

        if (luku1 < 0 || luku2 < 0)
        {
            Console.WriteLine("toinen luku oli liian pieni.");
            return;
        }
        Console.WriteLine(r.Next(luku1, luku2));
    }
    catch (FormatException)
    {
        Console.WriteLine("Syöte oli väärää muotoa!");
    }
    catch (Exception e)
    {
        Console.WriteLine($"tapahtui virhe! {e.Message}");
    }

}

// Harjoitus2();