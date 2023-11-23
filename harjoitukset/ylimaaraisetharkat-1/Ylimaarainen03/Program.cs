Console.Write("kokonaisluku: ");
int luku = int.Parse(Console.ReadLine());

if (luku < 0)
{
    Console.WriteLine("luku on negatiivinen");
}
else if (luku == 0)
{
    Console.WriteLine("luku on tasan nolla");
}
else
{
    Console.WriteLine("luku on positiivinen");
}