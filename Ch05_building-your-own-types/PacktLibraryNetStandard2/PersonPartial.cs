
namespace Packt.Shared;

public partial class Person
{
    // read-only property; only has a getter, no setters
    public string Origin
    {
        get
        {
            return string.Format(
                "{0} was born on {1}.",
                Name,
                HomePlanet
            );
        }
    }

    // lambda readonly properties; just defines what they return
    public string Greeting => $"{Name} says 'Hello!'";
    public int Age => DateTime.Today.Year - Born.Year;



    // automatic getter & setter
    public string? FavoriteIceCream { get; set; }



    // verbose/configurable getter & setter
    private string? _favoritePrimaryColor;
    public string? FavoritePrimaryColor
    {
        get
        {
            return _favoritePrimaryColor;
        }
        set
        {
            switch (value?.ToLower())
            {
                case "red":
                case "green":
                case "blue":
                    _favoritePrimaryColor = value;
                    break;
                default:
                    throw new ArgumentException(
                        $"{value} is not a primary color; choose from red, green, or blue."
                    );
            }
        }
    }



    private WondersOfTheAncientWorld _favoriteAncientWonder;

    public WondersOfTheAncientWorld FavoriteAncientWonder
    {
        get { return _favoriteAncientWonder; }
        set
        {
            string wonderName = value.ToString();
            if (wonderName.Contains(','))
            {
                throw new ArgumentException(
                    message: "Favorite ancient wonder can only contain a single enum value",
                    paramName: nameof(FavoriteAncientWonder)
                );
            }

            if (!Enum.IsDefined(typeof(WondersOfTheAncientWorld), value))
            {
                throw new ArgumentException(
                    message: $"{value} is not a member of WondersOfTheAncientWorld",
                    paramName: nameof(FavoriteAncientWonder)
                );
            }

            _favoriteAncientWonder = value;
        }
    }



    public Person this[int index]
    {
        get
        {
            return Children[index];
        }
        set
        {
            Children[index] = value;
        }
    }

    public Person this[string name]
    {
        get
        {
            // functional; find child where the child Person's p.Name matches the string given as an index
            return Children.Find(p => p.Name == name);
        }
    }
}
