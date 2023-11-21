string[] words = new string[10];

int count = 0;

string input = "";

while (true)
{
    Console.Write("Anna sana: ");
    input = Console.ReadLine();

    // jos "lopeta"
    if (input == "lopeta")
    {
        break;
    }

    words[count] = input;
    count++;

    if (count == words.Length)
    {
        break;
    }
}

string shortest = words[0];
string longest = words[0];

for (int i = 0; i < count; i++)
{
    string word = words[i];
    if (word.Length < shortest.Length)
    {
        shortest = word;
    }
    if (word.Length > longest.Length)
    {
        longest = word;
    }
}

Console.WriteLine("Syötit " + count + " sanaa");

Console.WriteLine("ensimmäinen: " + words[0] + ", viimeinen: " + words[count - 1]);

Console.WriteLine("Pisin: " + longest + ", lyhin: " + shortest);