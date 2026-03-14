using System.Reflection;

// uncomment the below line to get language & compiler version
// #error version

#region
{
    // #region is being used as an IDE directive, to make this area collapsible
    Console.WriteLine("Anonymous block in an isolated scope\n");

    // possible due to ItemGroup tags added to "Vocabulary.csproj" being reflected in "obj/Debug/net10.0/Vocabulary.GlobalUsings.g.cs"
    WriteLine($"From machine {Env.MachineName}: \"No.\"\n");

    Console.WriteLine(
        "Temperature on {0:D} is {1}°C\n",
        DateTime.Today,
        23.4
    );

    // nameof() can be used to stringify the name of its given item
    double heightInMeters = 1.88;
    Console.WriteLine(
        $"The variable {nameof(heightInMeters)}: {heightInMeters}\n"
    );
}
#endregion

// strings and chars...
{
    char digit = '1';
    string name = "joseph";

    char someChar = name[2]; // strings are exposed as char arrays
    string horizontalLine = new('-', count: 74); // 74 hyphens; from string class constructor
    string grinEmoji = char.ConvertFromUtf32(0x1F600); // emoji requiring a "surrogate pair" of chars to represent it

    // to display emojis, text encoding must be changed
    Console.OutputEncoding = System.Text.Encoding.UTF8;
    Console.WriteLine($"{grinEmoji}\n");

    // verbatim strings (@"") can be used instead of backslash escapes
    Console.WriteLine("C:\\some\\filesystem\\path");
    Console.WriteLine(@"C:\some\other\path");
    Console.WriteLine();

    // raw string literals; can use 3 or more enclosing quotes, indents entire string based on the indent of the ending quotes
    string xmlString = """
        <Person age="50">
            <FirstName>
                Mark
            </FirstName>
        </Person>
        """
    ;
    Console.WriteLine($"{xmlString}\n");

    // mixing interpolated strings with raw string literals
    // number of dollar signs indicates number of brackets needed to insert interpolated values
    var person = new { FirstName = "Alice", Age = 56 };
    string jsonString = $$"""
        {
            "first-name": "{{person.FirstName}}",
            "age": "{{person.Age}}",
            "calculation": "{{{1 + 2}}}"
        }
        """
    ;
    Console.WriteLine($"{jsonString}\n");
}
Console.WriteLine();

/*

BELOW IS REFLECTIVE ACQUISITION AND COUNT OF ALL TYPES LOADED FOR THIS PROGRAM

*/

// uncommenting the below loads more types for the program, giving further results
// System.Data.DataSet ds = new();
// HttpClient client = new();

// entry-point assembly for the application
Assembly? myApp = Assembly.GetEntryAssembly();

// null safety
if (myApp is null) return;

// loop through all assemblies (like libraries or modules) referenced by myApp
foreach (AssemblyName name in myApp.GetReferencedAssemblies())
{
    // load the assembly through its name in the list of referenced assemblies
    Assembly a = Assembly.Load(name);

    // get all types within the assembly & count their methods
    int methodCount = 0;
    foreach (TypeInfo t in a.DefinedTypes)
    {
        methodCount += t.GetMethods().Length;
    }


    WriteLine(
        "{0:N0} types with {1:N0} methods in {2} assembly",
        arg0: a.DefinedTypes.Count(),
        arg1: methodCount,
        arg2: name.Name
    );
}
Console.WriteLine();
