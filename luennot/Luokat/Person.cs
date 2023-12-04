class Person
{
    private string name;

    public string LastName { set; get; } = "nen-loppuinen";

    public Address Address { set; get; }

    // public string Name
    // {
    //     set
    //     {
    //         name = value;
    //     }
    //     get { return name; }
    // }

    // sama kuin yllä
    public string Name { set; get; }

    public Person(string _name)
    {
        name = _name;
    }
    public void Greet()
    {
        Console.WriteLine("moi " + name);
    }
}