int count = 0;
int even_count = 0;
double sum = 0;

while (count < 10)
{
    Console.Write("kokonaisluku: ");
    int luku = int.Parse(Console.ReadLine());

    count++;
    // parittomat luvut eivät kiinnosta
    if (luku % 2 != 0)
    {
        continue;
    }
    even_count++;

    sum += luku;

}

Console.WriteLine("sum " + sum);
Console.WriteLine("count " + count);
Console.WriteLine("even_count " + even_count);

Console.WriteLine($"Parillisten summa: {sum} ja keskiarvo: {sum / even_count}");
