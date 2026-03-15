// using static System.Console; // static import; "Console.WriteLine" can now be "WriteLine"

// numbered positional arguments - the {0}, {1}, etc. that might be seen in strings
using System.Threading.Tasks.Dataflow;

int appleCount = 12;
decimal unitPrice = 0.35M;

// arg0, arg1, arg2 can be named; any beyond this must be unnamed args (varargs overloaded method?)
WriteLine(
    format: "{0} apples cost {1:C}",
    arg0: appleCount,
    arg1: unitPrice * appleCount
);

string formatted = string.Format(
    format: "{0} apples cost {1:C}",
    arg0: appleCount,
    arg1: unitPrice * appleCount
);
// WriteToFile(formatted); // a hypothetical method that doesn't natively parse numbered positional args

// mixing named with unnamed args
WriteLine(
    "{0} {1} lived in {2}.",
    arg0: "Roger",
    arg1: "Cevung",
    arg2: "Stockholm"
);

// can use multiple of the same arg, like how there are 2 instances of {2} in this format string
WriteLine(
    "{0} {1} lived in {2} and worked in the {3} team at {4} {2}.",
    "Roger",
    "Cevung",
    "Stockholm",
    "Safety",
    "Optimized Experiences"
);



// interpolated string version of the format strings at the top of thie file...
WriteLine($"{appleCount} apples cost {unitPrice * appleCount:C}");



// format strings with alignments
// {A, B:C}; A is the arg index, B is the number of columns to align the text in, and C is the data format of the argument (N0, C, etc.)
string applesText = "Apples";
int applesCount = 1234;
string bananasText = "Bananas";
int bananasCount = 56789;

WriteLine();
WriteLine(
    format: "{0, -10} {1, 6}",
    arg0: "Name",
    arg1: "Count"
);
WriteLine(
    format: "{0, -10} {1, 6:N0}",
    arg0: applesText,
    arg1: applesCount
);
WriteLine(
    format: "{0, -10} {1, 6:N0}",
    arg0: bananasText,
    arg1: bananasCount
);



/*

numbers can have dynamic format codes in their brackets;
{0:N000.000} means 20.1 would display as "020.100"
{0:C} means  20.1 would display as currency "$20.10"
{0:E2} means exponential notation with 2 decimal places; 1234.567 becomes "1.23E+003"

(much) more at:
    https://learn.microsoft.com/en-us/dotnet/standard/base-types/custom-numeric-format-strings
    https://learn.microsoft.com/en-us/dotnet/standard/base-types/standard-numeric-format-strings

*/



// take basic console input
WriteLine();
Write("Type your screen name and press ENTER > ");
string? screenName = ReadLine(); // question mark tells compiler we're expecting a possible null value
Write("Type your age > ");
string ageInput = ReadLine()!; // "null-forgiving operator" - exclamation point tells compiler that this will not return null
WriteLine($"Hello {screenName}, you're looking good for {ageInput}!\n");



// key-combination reading
Write("Press any key combination > ");
ConsoleKeyInfo key = ReadKey();
WriteLine(
    "\nKey: {0}, Char: {1}, Modifiers: {2}\n",
    arg0: key.Key,
    arg1: key.KeyChar,
    arg2: key.Modifiers
);
