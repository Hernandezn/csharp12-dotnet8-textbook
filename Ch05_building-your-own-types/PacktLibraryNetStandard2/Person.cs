
namespace Packt.Shared;

public partial class Person : object
{
    public readonly string HomePlanet = "Earth";

    public readonly DateTime Instantiated;

    public const string Species = "Homo Sapiens";

    public string? Name;

    public DateTimeOffset Born;

    // MOVED to PersonPartial.cs
    // public WondersOfTheAncientWorld FavoriteAncientWonder;

    public WondersOfTheAncientWorld BucketList;

    public List<Person> Children = new();

    public Person()
    {
        Name = "Unknown";
        Instantiated = DateTime.Now;
    }

    public Person(string initialName, string homePlanet)
    {
        Name = initialName;
        HomePlanet = homePlanet;
        Instantiated = DateTime.Now;
    }

    public void WriteToConsole()
    {
        WriteLine($"{Name} was born on a {Born:dddd}.");
    }

    public string GetOrigin()
    {
        return $"{Name} was born on {HomePlanet}.";
    }

    public string SayHello()
    {
        return $"{Name} says 'Hello!'";
    }

    public string SayHello(string name)
    {
        return $"{Name} says 'Hello, {name}!'";
    }

    public string OptionalParameters(
        int count,
        string command = "Run!",
        double number = 0.0,
        bool active = true
    )
    {
        return string.Format(
            format: "command is {0}, number is {1}, active state is {2}",
            arg0: command,
            arg1: number,
            arg2: active
        );
    }

    public void PassingParameters(int w, in int x, ref int y, out int z)
    {
        // out z; MUST be set within the method
        z = 100;

        // in x; CANNOT be changed within the method
        w++;
        y++; // ref y; passed by reference, so changes here change the outside state of this item
        z++;

        WriteLine($"In the method: w = {w}, x = {x}, y = {y}, z = {z}");
    }

    public (string, int) GetFruit()
    {
        // returns a TUPLE
        return ("Apples", 5);
    }

    public (string Name, int Number) GetNamedFruit()
    {
        return (Name: "Apples", Number: 5);
    }

    public void Deconstruct(out string? name, out DateTimeOffset dob)
    {
        name = Name;
        dob = Born;
    }

    public void Deconstruct(out string? name, out DateTimeOffset dob, out WondersOfTheAncientWorld fav)
    {
        name = Name;
        dob = Born;
        fav = FavoriteAncientWonder;
    }


    public static int Factorial(int number)
    {
        if (number < 0)
        {
            throw new ArgumentException(
                $"{nameof(number)} cannot be less than zero."
            );
        }
        return localFactorial(number);

        // internal function
        int localFactorial(int localNumber)
        {
            if (localNumber == 0) return 1;
            return localNumber * localFactorial(localNumber - 1);
        }
    }
}
