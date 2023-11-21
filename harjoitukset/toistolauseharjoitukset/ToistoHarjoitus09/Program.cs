int[] numeroita = new int[10];

for (int i = 0; i < numeroita.Length; i++)
{
    numeroita[i] = i * 2;
}

// jokainen omalle rivilleen
// foreach (var numero in numeroita)
// {
//     Console.WriteLine(numero);
// }

// kaksi per rivi
for (int i = 0; i < numeroita.Length; i += 2)
{
    Console.WriteLine(numeroita[i] + ", " + numeroita[i + 1]);
}