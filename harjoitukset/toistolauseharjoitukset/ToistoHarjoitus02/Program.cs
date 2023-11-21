double[] luvut = { 3.0, 1.2, 2.8 };

double summa = 0.0;
// 2.1
// for (int i = 0; i < luvut.Length; i++)
// {
//     double luku = luvut[i];
//     summa = summa + luku;
// }

// 2.2
// int i = 0;
// while (i < luvut.Length)
// {
//     summa = summa + luvut[i];
//     i++;
// }

// 2.3
foreach (var luku in luvut)
{
    summa += luku;
}


Console.WriteLine(summa);