string[] sanat = new string[3];

string sana = "";
// 0 1 2
for (int k = 0; k < sanat.Length; k++)
{
    Console.Write("sana: ");
    sana = Console.ReadLine();
    sanat[k] = sana;
}

// 2 1 0
for (int j = sanat.Length - 1; j >= 0; j--)
{
    Console.WriteLine(sanat[j]);
}