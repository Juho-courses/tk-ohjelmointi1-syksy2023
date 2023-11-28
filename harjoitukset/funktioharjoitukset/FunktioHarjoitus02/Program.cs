// Luo funktio, jolla on kokonaislukuargumentti nimeltä ’n’. Funktio palauttaa
// arrayn jossa on kokonaisluvut 0 - n.
// • LuoArray(5) palauttaa [0,1,2,3,4,5]

int[] LuoArray(int n)
{
    int[] ret = new int[n + 1];
    for (int i = 0; i <= n; i++)
    {
        Console.WriteLine(i);
        ret[i] = i;
    }
    return ret;
}

Console.WriteLine("----");
// int[] luvut = [0,1,2,3....,50]
int[] luvut = LuoArray(5);
foreach (var item in luvut)
{
    Console.Write(item + " ");
}