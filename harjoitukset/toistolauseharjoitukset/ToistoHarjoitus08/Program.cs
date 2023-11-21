string[] sanoja = { "eka", "toka", "kolmas", "moi" };

foreach (var sana in sanoja)
{
    if (sana.Length < 3)
    {
        continue;
    }
    Console.WriteLine(sana);
}