
using Packt.Shared;

// aliasing for tuple types
using UnnamedParameters = (string, int);
using Fruit = (string Name, int Number);

ConfigureConsole();

Person bob = new();

bob.Name = "Bob Smith";
bob.Born =
    new DateTimeOffset(
        year: 1965,
        month: 12,
        day: 22,
        hour: 16,
        minute: 28,
        second: 0,
        offset: TimeSpan.FromHours(-5) // GMT -5; EST
    )
;
bob.FavoriteAncientWonder = WondersOfTheAncientWorld.StatueOfZeusAtOlympia;
bob.BucketList =
    WondersOfTheAncientWorld.HangingGardensOfBabylon
    | WondersOfTheAncientWorld.MausoleumAtHalicarnassus
;

Person alfred = new Person();
alfred.Name = "Alfred";
bob.Children.Add(alfred);
bob.Children.Add(new Person { Name = "Bella" });
bob.Children.Add(new() { Name = "Zoe" });

WriteLine(bob);
WriteLine("{0} was born on {1:D}.", bob.Name, bob.Born);
WriteLine(
    "{0}'s favorite Wonder is {1}. Its integer value is {2:N0}.",
    bob.Name,
    bob.FavoriteAncientWonder,
    (int)bob.FavoriteAncientWonder
);
WriteLine($"{bob.Name}'s bucket list is {bob.BucketList}.");
WriteLine($"{bob.Name} has {bob.Children.Count} children:");
foreach (Person child in bob.Children)
{
    WriteLine($"> {child.Name}");
}
WriteLine($"{bob.Name} is a {Person.Species}, born on {bob.HomePlanet}.");
bob.WriteToConsole();
WriteLine(bob.GetOrigin());
WriteLine(bob.SayHello());
WriteLine(bob.SayHello("Emily"));
WriteLine(bob.OptionalParameters(3));
WriteLine(bob.OptionalParameters(3, "Jump!", 98.5));
WriteLine(bob.OptionalParameters(3, number: 52.7, command: "Hide!"));
WriteLine(bob.OptionalParameters(3, "Poke!", active: false));



WriteLine();



Person alice = new()
{
    Name = "Alice Jones",
    Born = new(1998, 3, 7, 16, 28, 0, TimeSpan.Zero)
};
WriteLine("{0} was born on {1:d}.", alice.Name, alice.Born);



BankAccount.InterestRate = 0.012M;
BankAccount jonesAccount = new();
jonesAccount.AccountName = "Mrs. Jones";
jonesAccount.Balance = 2400;

WriteLine(
    format: "{0} earned {1:C} interest.",
    arg0: jonesAccount.AccountName,
    arg1: jonesAccount.Balance * BankAccount.InterestRate
);

BankAccount gerrierAccount = new();
gerrierAccount.AccountName = "Ms. Gerrier";
gerrierAccount.Balance = 98;
WriteLine(
    format: "{0} earned {1:C} interest.",
    arg0: gerrierAccount.AccountName,
    arg1: gerrierAccount.Balance * BankAccount.InterestRate
);
WriteLine();



// Book book = new()
// {
//     Isbn = "978-1803237800",
//     Title = "C# 12 and .NET 8 - Modern Cross-Platform Development Fundamentals"
// };
Book book = new(
    isbn: "978-1803237800",
    title: "C# 12 and .NET 8 - Modern Cross-Platform Development Fundamentals"
)
{
    Author = "Mark J. Price",
    PageCount = 821
};
WriteLine(
    "{0}: {1}, written by {2}, has {3:N0} pages.\n",
    book.Isbn,
    book.Title,
    book.Author,
    book.PageCount
);



Person blankPerson = new();
WriteLine(
    format: "{0} of {1} was created at {2:hh:mm:ss} on a {2:dddd}.",
    arg0: blankPerson.Name,
    arg1: blankPerson.HomePlanet,
    arg2: blankPerson.Instantiated
);
Person gunny = new(initialName: "Gunny", homePlanet: "Mars");
WriteLine(
    format: "{0} of {1} was created at {2:hh:mm:ss} on a {2:dddd}.\n",
    gunny.Name,
    gunny.HomePlanet,
    gunny.Instantiated
);



int a = 10;
int b = 20;
int c = 30;
int d = 40;
WriteLine($"Before: a = {a}, b = {b}, c = {c}, d = {d}");
bob.PassingParameters(a, b, ref c, out d);
WriteLine($"After: a = {a}, b = {b}, c = {c}, d = {d}\n");



int e = 50;
int f = 60;
int g = 70;
WriteLine($"Before: e = {e}, f = {f}, g = {g}, h doesn't exist");
bob.PassingParameters(e, g, ref g, out int h);
WriteLine($"After: e = {e}, f = {f}, g = {g}, h = {h}\n");



// tuple type
(string, int) fruit = bob.GetFruit();
WriteLine($"there are {fruit.Item2} instances of {fruit.Item1}");

// using the tuple alias defined at the top of the file
Fruit fruitNamed = bob.GetNamedFruit();
WriteLine($"There are {fruitNamed.Number} {fruitNamed.Name}");



(string, int) thing1 = ("Neville", 4);
WriteLine($"{thing1.Item1} has {thing1.Item2} children");

// var type inference to tuple
var thing2 = (bob.Name, bob.Children.Count);
// tuple name inferences to .Name & .Count
WriteLine($"{thing2.Name} has {thing2.Count} children\n");



// tuple-type return value, stored in a tuple-type variable
(string fruitName, int fruitNumber) namedFields = bob.GetNamedFruit();
WriteLine($"{namedFields.fruitName}, {namedFields.fruitNumber}");

// tuple-type return value, deconstructed into 2 separate variables
(string fruitName, int fruitNumber) = bob.GetNamedFruit();
WriteLine($"{fruitName}, {fruitNumber}\n");



// object deconstruction using Deconstruct() implicit method calls
var (name1, dob1) = bob;
WriteLine($"Deconstructed person: {name1}, {dob1}");
var (name2, dob2, fav2) = bob;
WriteLine($"Deconstructed person: {name2}, {dob2}, {fav2}\n");



int number = -1;
try
{
    WriteLine($"{number}! is {Person.Factorial(number)}\n");
}
catch (Exception exc)
{
    WriteLine($"{exc.GetType()} says: {exc.Message}\n");
}



Person sam = new()
{
    Name = "Sam",
    Born = new(1969, 6, 25, 0, 0, 0, TimeSpan.Zero)
};
WriteLine(sam.Origin);
WriteLine(sam.Greeting);
WriteLine(sam.Age);

sam.FavoriteIceCream = "Chocolate Fudge";
WriteLine($"Sam's favorite ice cream is {sam.FavoriteIceCream}");

string color = "turquoise";
try
{
    sam.FavoritePrimaryColor = color;
    WriteLine($"Sam's favorite primary color is {sam.FavoritePrimaryColor}\n");
}
catch (Exception exc)
{
    WriteLine(
        "Tried to set {0} to '{1}': {2}\n",
        nameof(sam.FavoritePrimaryColor),
        color,
        exc.Message
    );
}



// // multiple & invalid enum values to show the exceptions thrown from this property's setter in PersonPartial.cs
// sam.FavoriteAncientWonder = WondersOfTheAncientWorld.StatueOfZeusAtOlympia | WondersOfTheAncientWorld.GreatPyramidOfGiza;
// sam.FavoriteAncientWonder = (WondersOfTheAncientWorld)128;



sam.Children.AddRange(
    new() { Name = "Charlie", Born = new(2010, 3, 18, 0, 0, 0, TimeSpan.Zero) },
    new() { Name = "Ella", Born = new(2020, 12, 24, 0, 0, 0, TimeSpan.Zero) }
);

WriteLine($"Sam's first child is {sam.Children[0].Name}");
WriteLine($"Sam's second child is {sam.Children[1].Name}");

// using index of sam, as if sam was an array
WriteLine($"Sam'e first child is {sam[0].Name}");
WriteLine($"Sam's second child is {sam[1].Name}");

// using string index, defined in the Person this[string name] indexer in PersonPartial.cs
WriteLine($"Sam's child named Ella is {sam["Ella"].Age} years old\n");



Passenger[] passengers =
{
    new Passenger.FirstClassPassenger { AirMiles = 1_419, Name = "Suman" },
    new Passenger.FirstClassPassenger { AirMiles = 16_562, Name = "Lucy" },
    new Passenger.BusinessClassPassenger { Name = "Janice" },
    new Passenger.CoachClassPassenger { CarryOnKG = 25.7, Name = "Dave" },
    new Passenger.CoachClassPassenger { CarryOnKG = 0, Name = "Amit" }
};

foreach (Passenger passenger in passengers)
{
    decimal flightCost = passenger switch
    {
        // Passenger.FirstClassPassenger p when p.AirMiles > 35_000 => 1_500M,
        // Passenger.FirstClassPassenger p when p.AirMiles > 15_000 => 1_750M,
        // Passenger.FirstClassPassenger _ => 2_000M,
        Passenger.FirstClassPassenger p => p.AirMiles switch
        {
            > 35_000 => 1_500M,
            > 15_000 => 1_750M,
            _ => 2_000M
        },

        Passenger.BusinessClassPassenger _ => 1_000M,

        // Passenger.CoachClassPassenger p when p.CarryOnKG < 10.0 => 500M,
        Passenger.CoachClassPassenger { CarryOnKG: < 10.0 } => 500M,

        Passenger.CoachClassPassenger _ => 650M,
        _ => 800M
    };

    WriteLine($"Flight costs {flightCost:C} for {passenger}");
}
WriteLine();



ImmutablePerson jeff = new()
{
    FirstName = "Jeff",
    LastName = "Winger"
};
// cannot be set again, as FirstName is an init-only property
// jeff.FirstName = "Geoff";



ImmutableVehicle car = new()
{
    Brand = "Mazda MX-5 RF",
    Color = "Soul Red Crystal Metallic",
    Wheels = 4
};
ImmutableVehicle repaintedCar = car with { Color = "Polymetal Grey Metallic" };
WriteLine($"Original car color was {car.Color}");
WriteLine($"New car color is {repaintedCar.Color}\n");



AnimalClass ac1 = new() { Name = "Rex" };
AnimalClass ac2 = new() { Name = "Rex" };
WriteLine($"ac1 == ac2 ? {ac1 == ac2}");

AnimalRecord ar1 = new() { Name = "Rex" };
AnimalRecord ar2 = new() { Name = "Rex" };
WriteLine($"ar1 == ar2 ? {ar1 == ar2}");

ImmutableAnimal oscar = new("Oscar", "Labrador");
var (who, what) = oscar; // calls Deconstruct method implicit in Records.cs
WriteLine($"{who} is a {what}\n");



Headset vp = new("Apple", "Vision Pro");
WriteLine($"{vp.ProductName} is made by {vp.Manufacturer}");

Headset holo = new();
WriteLine($"{holo.ProductName} is made by {holo.Manufacturer}");
Headset mq = new() { Manufacturer = "Meta", ProductName = "Quest 3" };
WriteLine($"{mq.ProductName} is made by {mq.Manufacturer}");
