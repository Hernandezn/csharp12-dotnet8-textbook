
using System.IO.Compression;

Write("Enter your new password > ");
string? password = ReadLine();
if(password?.Length < 8)
{
    WriteLine("Your Password is too short. Use at least 8 characters.");
} 
else
{
    WriteLine("Your password is accepted.");
}
WriteLine();



// "is" boolean statement that performs type checking
object o1 = "3";
object o2 = 3;
int j = 4;

if(o1 is int i1) // o1 int check (it's a string)
{
    WriteLine($"{i1} x {j} = {i1 * j}");
}
else
{
    WriteLine("o1 is not an int, so it cannot multiply!");
}

if(o2 is int i2) // o2 int check (it's an int)
{
    WriteLine($"{i2} x {j} = {i2 * j}");
}
else
{
    WriteLine("o2 is not an int, so it cannot multiply!");
}
WriteLine();



int someNum = Random.Shared.Next(minValue: 1, maxValue: 8); // "Shared" is a thread-safe Random instance
WriteLine($"My random number is {someNum}");
switch(someNum)
{
    case 1:
        WriteLine("One");
        break;
    case 2:
        WriteLine("Two");
        goto case 1; // stay wary of goto; risks making code difficult to understand 
    case 3:
    case 4:
        WriteLine("Three or four");
        goto case 1;
    case 5:
        goto A_label;
    case 7:
        WriteLine("Rolled a 7! Ending program...");
        return;
    default:
        WriteLine("Default");
        break;
}
WriteLine("After end of switch");
A_label:
WriteLine("After A_label\n");



var animals = new Animal?[] // nullable animals array
{
    new Cat
    {
        Name = "Karen",
        Born = new(year: 2022, month: 12, day: 23),
        Legs = 4,
        IsDomestic = true
    },
    null,
    new Cat
    {
        Name = "Mufasa",
        Born = new(year: 1994, month: 2, day: 12),
        Legs = 3
    },
    new Spider
    {
        Name = "Sid Vicious",
        Born = new(year: 2023, month: 4, day: 30),
        Legs = 8,
        IsPoisonous = true
    },
    new Spider
    {
        Name = "Captain Furry",
        Born = new(year: 2023, month: 3, day: 19),
        Legs = 8,
        IsPoisonous = false
    }
};


// PATTERN MATCHING USING "WHEN" IN SWITCH CASES
foreach (Animal? animal in animals)
{
    string message;
    switch(animal)
    {
        case Cat fourLeggedCat when fourLeggedCat.Legs == 4: // can also be "case Cat { Legs: 4 } fourLeggedCat:"
            message = $"The cat named {fourLeggedCat.Name} has four legs.";
            break;
        case Cat wildCat when !wildCat.IsDomestic:
            message = $"The non-domestic cat is named {wildCat.Name}.";
            break;
        case Cat cat:
            message = $"The cat is named {cat.Name}.";
            break;
        default:
            message = $"{animal.Name} is a {animal.GetType()}.";
            break;
        case Spider spider when spider.IsPoisonous:
            message = $"The {spider.Name} spider is poisonous.";
            break;
        case null:
            message = "There is no animal here!";
            break;
    }
    WriteLine($"switch statement: {message}");
}
WriteLine();


// EQUIVALENT SWITCH EXPRESSION TO THE SWITCH CASE ABOVE
foreach (Animal? animal in animals)
{
    string message;

    message = animal switch
    {
        Cat { Legs: 4 } fourLeggedCat 
            => $"The cat named {fourLeggedCat.Name} has four legs.",
        Cat wildCat when !wildCat.IsDomestic
            => $"The non-domestic cat is named {wildCat.Name}.",
        Cat cat
            => $"The cat is named {cat.Name}.",
        Spider spider when spider.IsPoisonous
            => $"The {spider.Name} spider is poisonous.",
        null
            => "There is no animal here!",
        _
            => $"{animal.Name} is a {animal.GetType()}."
    }; // mind that this form of switch needs a semicolon
    WriteLine($"switch expression: {message}");
}
WriteLine();

