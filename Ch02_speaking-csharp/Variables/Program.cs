using System.Xml; // to use XmlDocument

// default type values
Console.WriteLine($"default(int) = {default(int)}");
Console.WriteLine($"default(bool) = {default(bool)}");
Console.WriteLine($"default(DateTime) = {default(DateTime)}");
Console.WriteLine($"default(string) = {default(string)}\n");

// default as a keyword will select the default value for the type it's being used as
int num = 13;
num = default; // resets to 0



// object is a legacy/slow-performance variable type whose use may be needed for interoperability with other code
object height = 1.88; // double stored in object
object name = "Amir"; // string stored in object
Console.WriteLine($"{name} is {height} meters tall.");

// int length1 = name.Length; // compile error; compiler says it's object, not string, so it doesn't have a Length property
int length2 = ((string)name).Length; // cast to string, get no more error
Console.WriteLine($"{name} has {length2} characters.\n");

// dynamic can employ type inference to use properties of the concrete type assigned to it
dynamic something;
something = new[] {1, 1, 2, 3, 5};
something = 12;
something = "Ahmed";

// infers that the variable is currently a string, invokes its properties, and identifies its type
Console.WriteLine($"The length of something is {something.Length}");
Console.WriteLine($"The something variable is a {something.GetType()}\n");

// compiler type inferences using var; can mouse over each "var" in the IDE to see its inference
var population = 67_000_000; // int
var weight = 1.88; // double
var price = 4.99M; // decimal
var fruit = "Apples"; // string
var letter = 'Z'; // char
var happy = true; // bool

// happy = 3; // CANNOT reassign the type of a var; its type inference is final upon assignment

// can reduce verbosity using var
var xml1 = new XmlDocument();
XmlDocument xml2 = new XmlDocument();

// CANNOT tell the type here if using var; can reduce maintainability with its misuse
var file1 = File.CreateText("something1.txt");
StreamWriter file2 = File.CreateText("something2.txt");

// target-typed new; infers the constructor from the declared variable type
XmlDocument xml3 = new();



// the second "new" infers DateTime using its type definition within the Person class at the bottom
Person kim = new();
kim.BirthDate = new(1967, 12, 26); // infers that this is a DateTime



// also infers the generic; it's a Person List
List<Person> people = new()
{
    new() { FirstName = "Alice" }, // infers that this is a person
    new() { FirstName = "Bob" },
    new() { FirstName = "Charlie" }
};



class Person
{
    public string FirstName;

    public DateTime BirthDate;
}
