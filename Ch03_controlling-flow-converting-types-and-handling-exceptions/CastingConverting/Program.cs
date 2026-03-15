using System.Globalization;
using static System.Convert;



int a = 10;
double b = a;
WriteLine($"a is {a}, b is {b}\n");

double c = 9.8;
int d = (int)c;
WriteLine($"c is {c}, d is {d}\n");

long e = 5_000_000_000;
int f = (int)e;
WriteLine($"e is {e:N0}, f is {f:N0}");
e = long.MaxValue;
f = (int) e;
WriteLine($"e is {e:N0}, f is {f:N0}\n");


WriteLine("{0,12} {1,34}", "Decimal", "Binary");
WriteLine("{0,12} {0,34:B32}", int.MaxValue);
for (int i = 8; i >= -8; i--)
{
    WriteLine("{0,12} {0,34:B32}", i);
}
WriteLine("{0,12} {0,34:B32}\n", int.MinValue);



double g = 9.8;
int h = ToInt32(g); // System.Convert.ToInt32()
WriteLine($"g is {g}, h is {h}\n");



double[,] doubles =
{
    { 9.49, 9.5, 9.51 },
    { 10.49, 10.5, 10.51 },
    { 11.49, 11.5, 11.51 },
    { 12.49, 12.5, 12.51 },
    { -12.49, -12.5, -12.51 },
    { -11.49, -11.5, -11.51 },
    { -10.49, -10.5, -10.51 },
    { -9.49, -9.5, -9.51 }
};
WriteLine("| double | ToInt32 | double | ToInt32 | double | ToInt32 |");
for (int x = 0; x < 8; x++)
{
    for (int y = 0; y < 3; y++)
    {
        Write($"| {doubles[x, y], 6} | {ToInt32(doubles[x, y]), 7} ");
    }
    WriteLine("|");
}
WriteLine();



foreach (double n in doubles)
{
    WriteLine(
        format: "Math.Round({0}, 0, MidpointRounding.AwayFromZero) = {1}",
        arg0: n,
        arg1: 
            Math.Round(
                value: n,
                digits: 0, 
                mode: MidpointRounding.AwayFromZero
            )
    );
}
WriteLine();



int number = 12;
WriteLine(number.ToString());
bool boolean = true;
WriteLine(boolean.ToString());
DateTime now = DateTime.Now;
WriteLine(now.ToString());
object me = new();
WriteLine(me.ToString());
WriteLine();



//base64 encoding -- converting raw binary to a string of safe characters, to aid interpretation between machines
byte[] binaryObject = new byte[128];
Random.Shared.NextBytes(binaryObject); // populates array with randomb bytes
WriteLine("Binary bytes:");
foreach (byte element in binaryObject)
{
    Write($"{element:X2}"); // X2 for hexadecimal notation with length 2, with leading zeros if needed
}
WriteLine();

string encoded = ToBase64String(binaryObject);
WriteLine($"Binary Object as Base64: {encoded}\n");



CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo(9);
int friends = int.Parse("27");
DateTime birthday = DateTime.Parse("4 June 1980");
WriteLine($"I have {friends} friends to invite to my party.");
WriteLine($"My birthday is {birthday}.");
WriteLine($"My birthday is {birthday:D}.\n");



Write("How many eggs are there? > ");
string? input = ReadLine();
if (int.TryParse(input, out int count)) // out allows TryParse to set a new int variable containing the parsed input
{
    WriteLine($"There are {count} eggs.");
}
else
{
    WriteLine("I could not parse the input.");
}
WriteLine();



// instance of out and "Try____" method form; there's also a "Create" method that would throw an exception (a relatively expensive process) if it failed
bool uriCanBeCreated = Uri.TryCreate("https://localhost:5000/api", UriKind.Absolute, out Uri serviceUrl);

