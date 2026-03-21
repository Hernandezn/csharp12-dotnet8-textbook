namespace Packt.Shared;

public class Person : IComparable<Person?>
{
    public string? Name { get; set; }
    public DateTimeOffset Born { get; set; }
    public List<Person> Children = new();
    public List<Person> Spouses = new();

    public event EventHandler? Shout;

    public int AngerLevel;

    // read-only lambda-defined property
    public bool Married => Spouses.Count > 0;

    public void WriteToConsole()
    {
        WriteLine($"{Name} was born on {Born:dddd}.");
    }

    public void WriteChildrenToConsole()
    {
        string term = Children.Count == 1 ? "child" : "children";
        WriteLine($"{Name} has {Children.Count} {term}.");
    }

    public static void Marry(Person p1, Person p2)
    {
        ArgumentNullException.ThrowIfNull(p1);
        ArgumentNullException.ThrowIfNull(p2);

        if (p1.Spouses.Contains(p2) || p2.Spouses.Contains(p1))
        {
            throw new ArgumentException(
                string.Format(
                    "{0} is already married to {1}",
                    arg0: p1.Name,
                    arg1: p2.Name
                )
            );
        }

        p1.Spouses.Add(p2);
        p2.Spouses.Add(p1);
    }

    // instance method that calls the static method above
    public void Marry(Person partner)
    {
        Marry(this, partner);
    }

    public void OutputSpouses()
    {
        if (Married)
        {
            string term = Spouses.Count == 1 ? "person" : "people";
            WriteLine($"{Name} is married to {Spouses.Count} {term}.");

            foreach (Person spouse in Spouses)
            {
                WriteLine($"    {spouse.Name}");
            }
        }
        else
        {
            WriteLine($"{Name} is a singleton.");
        }
    }



    /// <summary>
    ///     Static method to "multiply" or procreate
    /// </summary>
    /// <param name="p1">Parent 1</param>
    /// <param name="p2">Parent 2</param>
    /// <returns>A Person object that is the child of the input parents</returns>
    /// <exception cref="ArgumentNullException">If p1 and/or p2 are null</exception>
    /// <exception cref="ArgumentException">If p1 and p2 aren't married</exception>
    public static Person Procreate(Person p1, Person p2)
    {
        ArgumentNullException.ThrowIfNull(p1);
        ArgumentNullException.ThrowIfNull(p2);

        if (!p1.Spouses.Contains(p2) && !p1.Spouses.Contains(p2))
        {
            throw new ArgumentException(
                string.Format(
                    "{0} must be married to {1} to procreate with them.",
                    p1.Name,
                    p2.Name
                )
            );
        }

        Person baby = new()
        {
            Name = $"Baby of {p1.Name} and {p2.Name}",
            Born = DateTimeOffset.Now
        };
        p1.Children.Add(baby);
        p2.Children.Add(baby);
        return baby;
    }

    public Person ProcreateWith(Person partner)
    {
        return Procreate(this, partner);
    }

    // OPERATOR DEFINITION
    public static bool operator +(Person p1, Person p2)
    {
        Marry(p1, p2);

        return p1.Married && p2.Married;
    }

    public static Person operator *(Person p1, Person p2)
    {
        return Procreate(p1, p2);
    }

    

    // operator definitions used to define the == operator;
    // book claims this is beyond its scope, but it provides sufficient explanation to implement this
    // public static bool operator ==(Person p1, Person p2)
    // {
    //     return p1.Name == p2.Name;
    // }
    // public static bool operator !=(Person p1, Person p2)
    // {
    //     return p1.Name != p2.Name;
    // }



    public void Poke()
    {
        AngerLevel++;

        if (AngerLevel < 3) return;

        // shout holds your delegates (event listeners)
        if (Shout is not null)
        {
            // these parameters are sent to all your shout delegates (event listeners)
            Shout(this, EventArgs.Empty);
        }
    }



    public int CompareTo(Person? other)
    {
        int position;
        if (other is not null)
        {
            if ((Name is not null) && (other.Name is not null))
            {
                position = Name.CompareTo(other.Name);
            }
            else if ((Name is not null) && (other.Name is null))
            {
                position = -1;
            }
            else if ((Name is null) && (other.Name is not null))
            {
                position = 1;
            }
            else
            {
                position = 0;
            }
        }
        else if (other is null)
        {
            position = -1;
        }
        else
        {
            position = 0;
        }

        return position;
    }



    public override string ToString()
    {
        return $"{Name} is a {base.ToString()}.";
    }



    public void TimeTravel(DateTime when)
    {
        if (when <= Born)
        {
            throw new PersonException("Cannot travel to before birth!");
        }
        else
        {
            WriteLine($"Welcome to {when: yyyy}!");
        }
    }
}
