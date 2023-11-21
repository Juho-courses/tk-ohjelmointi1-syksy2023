int count = 0;

string input = "";
string first = "";
string last = "";
string shortest = "";
string longest = "";

while (true)
{
    Console.Write("Anna sana: ");
    input = Console.ReadLine();

    // jos "lopeta"
    if (input == "lopeta")
    {
        break;
    }

    if (first == "")
    {
        first = input;
        shortest = input;
    }

    last = input;

    if (input.Length < shortest.Length)
    {
        shortest = input;
    }
    if (input.Length > longest.Length)
    {
        longest = input;
    }

    count++;

    if (count == 10)
    {
        break;
    }
}

Console.WriteLine("Syötit " + count + " sanaa");

Console.WriteLine("ensimmäinen: " + first + ", viimeinen: " + last);

Console.WriteLine("Pisin: " + longest + ", lyhin: " + shortest);