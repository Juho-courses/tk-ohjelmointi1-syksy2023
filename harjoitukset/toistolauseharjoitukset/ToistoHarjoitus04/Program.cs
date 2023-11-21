string[] sanat = new string[3];

// string sana = "";
// 0 1 2
int k = 0;
// for (int k = 0; k < sanat.Length; k++) {}
while (k < sanat.Length)
{
    Console.Write("sana: ");
    // sana = Console.ReadLine();
    sanat[k] = Console.ReadLine();
    k++;
}

// 2 1 0
k = sanat.Length - 1;
while (k >= 0)
{
    Console.WriteLine(sanat[k]);
    k--;
}
