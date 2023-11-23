Console.Write("sana: ");
string syote = Console.ReadLine();

// reverse vaihtoehto 1
string kaannetty = "";
for (int i = syote.Length - 1; i >= 0; i--)
{
    kaannetty += syote[i];
}

// reverse vaihtoehto 2
char[] syote_chars = syote.ToCharArray();
Array.Reverse(syote_chars);
kaannetty = new string(syote_chars);

// reverse vaihtoehto 3
kaannetty = string.Join("", syote.Reverse().ToArray());

// tarkistus
bool isPalindrome = true;
for (int i = 0; i < syote.Length; i++)
{
    if (syote[i] != kaannetty[i])
    {
        isPalindrome = false;
        break;
    }
}

if (isPalindrome)
{
    Console.WriteLine("Syötety sana on palindromi");
}
else
{
    Console.WriteLine("Syötetty sana EI ole palindromi");
}