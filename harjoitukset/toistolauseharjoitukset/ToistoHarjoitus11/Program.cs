Console.Write("montako sanaa: ");
int user_count = int.Parse(Console.ReadLine());

int count = 0;
int pituudet_yhdessa = 0;

string sana = "";
while (count < user_count)
{
    Console.Write("sana: ");
    sana = Console.ReadLine();
    if (sana == "")
    {
        continue;
    }
    pituudet_yhdessa += sana.Length;
    count++;
}
Console.WriteLine($"Yhteenlaskettu pituus {pituudet_yhdessa}");