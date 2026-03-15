
#region unaries

using System.Security.Cryptography;

int a = 3;
int b = a++;

WriteLine($"a is {a}, b is {b}");

int c = 3;
int d = ++c;

WriteLine($"c is {c}, d is {d}\n");

#endregion



int e = 11;
int f = 3;
WriteLine($"e is {e}, f is {f}");
WriteLine($"e + f = {e + f}");
WriteLine($"e - f = {e - f}");
WriteLine($"e * f = {e * f}");
WriteLine($"e / f = {e / f}");
WriteLine($"e % f = {e % f}\n");

double g = 11;
WriteLine($"g is {g:N2}, f is {f}");
WriteLine($"g / f = {g / f:N2}\n");

int num = 6;
num += 3;
num= 3;
num= 3;
num= 3;
num= 3;
// all java-like so far...



// Null-coalescing operators
Write("Press ENTER > ");
string? authorName = ReadLine().Length > 0 ? null : null; // expecting a string or null

int maxLength = authorName?.Length ?? 30; // null-safe for a null authorName, sets to 30 if authorName or Length are null

authorName ??= "unknown"; // sets authorName to "unknown" if it's currently null



bool p = true;
bool q = false;
string spacer = "      |       |      ";

WriteLine("AND   | p     | q    ");
WriteLine($"p     |{p & p, -5} | {p & q, -5}");
WriteLine($"q     |{q & p, -5} | {q & q, -5}");
WriteLine(spacer);

WriteLine("OR    | p     | q    ");
WriteLine($"p     | {p | p, -5} | {p | q, -5}");
WriteLine($"q     | {q | p, -5} | {q | q, -5}");
WriteLine(spacer);

WriteLine("XOR   | p     | q    ");
WriteLine($"p     | {p ^ p, -5} | {p ^ q, -5}");
WriteLine($"q     | {q ^ p, -5} | {q ^ q, -5}");
WriteLine();



static bool DoStuff()
{
    WriteLine("DoStuff called!");
    return true;
}

WriteLine($"p & DoStuff() = {p & DoStuff()}"); // calls DoStuff
WriteLine($"q & DoStuff() = {q & DoStuff()}\n"); // calls DoStuff

WriteLine($"p & DoStuff() = {p && DoStuff()}"); // calls DoStuff
WriteLine($"q & DoStuff() = {q && DoStuff()}\n"); // does not call DoStuff; the && guards it when q is false



int x = 10;
int y = 6;

WriteLine("Expression | Decimal |   Binary");
WriteLine(new string('-', count: 31));
WriteLine($"x          | {x, 7} | {x:B8}");
WriteLine($"y          | {y, 7} | {y:B8}");
WriteLine($"x & y      | {x & y, 7} | {x & y:B8}");
WriteLine($"x | y      | {x | y, 7} | {x | y:B8}");
WriteLine($"x ^ y      | {x ^ y, 7} | {x ^ y:B8}");
WriteLine($"x << 3     | {x << 3, 7} | {x << 3:B8}"); // bit-shift left
WriteLine($"x * 8      | {x * 8, 7} | {x * 8:B8}"); // multiplication by 8; equivalent result to bit-shift by 3
WriteLine($"y >> 1     | {y >> 1, 7} | {y >> 1:B8}\n"); // bit shift right



int age = 50;
WriteLine($"The {typeof(int)} {nameof(age)} variable uses {sizeof(int)} bytes");

