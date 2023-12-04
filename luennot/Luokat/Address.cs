class Address
{
    public string StreetName { get; private set; }
    public int StreetNumber { get; private set; }

    // Address("satakunnankatu", 23)
    public Address(string _name, int _number)
    {
        StreetName = _name;
        StreetNumber = _number;
    }

    public void Tulosta()
    {
        Console.WriteLine($"{StreetName} {StreetNumber}");
    }
    public string PalautaOsoite()
    {
        return $"{StreetName} {StreetNumber}";
    }
}