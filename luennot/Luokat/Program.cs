Person ihminen = new Person("Matti");
// ihminen.Greet();
// Console.WriteLine(ihminen.Name);
// Console.WriteLine(ihminen.LastName);
// ihminen.LastName = "Virta";
// Console.WriteLine(ihminen.LastName);
// ihminen.Name = "MAtti2";
// Console.WriteLine(ihminen.Name);

Address osoite = new Address("Satakunnankatu", 23);
ihminen.Address = osoite;
ihminen.Address.Tulosta();
Console.WriteLine(ihminen.Address.PalautaOsoite().Length);

// Person i2 = new Person("Ville");
// i2.Greet();
