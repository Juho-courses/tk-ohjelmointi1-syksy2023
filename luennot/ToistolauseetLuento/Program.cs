int[] ints = { 12, 123, 923923, 1231, 123 };

int i = 0;
while (i < ints.Length)
{
    Console.WriteLine(ints[i]);
    i++;
}

// foreach (int luku in ints)
// {
//     if (luku == 123)
//     {
//         break;
//     }
//     Console.WriteLine(luku);
// }

// for (int i = 0; i <= ints.Length - 1; i++)
// {
//     // Console.WriteLine("i: " + i);
//     Console.WriteLine(ints[i]);
// }

// for (alustus; ehto; muutos)
// for (int i = 2; i < 10; i += 20)
// {
//     Console.WriteLine(i);
// }
// suoritus