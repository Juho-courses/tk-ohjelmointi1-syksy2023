string[] sanat = { "eka", "toka", "viides" };

// 1.1
foreach (string sana in sanat)
{
    Console.WriteLine(sana);
}

// 1.2
for (int i = 0; i < sanat.Length; i++)
{
    Console.WriteLine(sanat[i]);
}

// 1.3
int j = 0;
while (j < sanat.Length)
{
    Console.WriteLine(sanat[j]);
    j++;
}