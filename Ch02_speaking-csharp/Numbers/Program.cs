
/*
uint unsignedNaturalNumber = 23;

int integerNumber = -23;

short numberUsingLessMemory = 23;

long numberUsingMoreMemory = 23L;

ulong unsignedNumberUsingMoreMemory = 23UL;

int binaryNumber = 0b00010111;

int hexadecimalNumber = 0x17;

float realNumber = 2.3f;

double higherPrecisionReal = 2.3; // or 2.3d

decimal highestPrecisionReal = 2.3m;
*/

int decimalNotation = 2_000_000;
int binaryNotation = 0b_0001_1110_1000_0100_1000_0000;
int hexadecimalNotation = 0x_001E_8480;

Console.WriteLine("Decimal/binary/hex equality checks...");
Console.WriteLine($"{decimalNotation == binaryNotation}");
Console.WriteLine($"{decimalNotation == hexadecimalNotation}\n");

// N0 to indicate display as numbers with 0 places behind the dot
Console.WriteLine("Decimal value checks...");
Console.WriteLine($"{decimalNotation:N0}");
Console.WriteLine($"{binaryNotation:N0}");
Console.WriteLine($"{hexadecimalNotation:N0}\n");

// X to indicate display as hexadecimal numbers
Console.WriteLine("Hex value checks...");
Console.WriteLine($"{decimalNotation:X}");
Console.WriteLine($"{binaryNotation:X}");
Console.WriteLine($"{hexadecimalNotation:X}\n");

// N0 to indicate display as numbers with 0 places behind the dot
Console.WriteLine("int/double/decimal types' memory footprints...");
Console.WriteLine($"int uses {sizeof(int)} bytes and can store numbers in the range {int.MinValue:N0} to {int.MaxValue:N0}");
Console.WriteLine($"double uses {sizeof(double)} bytes and can store numbers in the range {double.MinValue:N0} to {double.MaxValue:N0}");
Console.WriteLine($"decimal uses {sizeof(decimal)} bytes and can store numbers in the range {decimal.MinValue:N0} to {decimal.MaxValue:N0}\n");

Console.WriteLine("Using doubles:");
double a = 0.1;
double b = 0.2;
Console.WriteLine($"{a} + {b} {((a + b == 0.3) ? "equals" : "does NOT equal")} {0.3}\n");

Console.WriteLine("Using floats:");
float c = 0.1F;
float d = 0.2f;
Console.WriteLine($"{c} + {d} {((c + d == 0.3f) ? "equals" : "does NOT equal")} {0.3f}\n");

Console.WriteLine("Using decimals:");
decimal e = 0.1M;
decimal f = 0.2m;
Console.WriteLine($"{e} + {f} {((e + f == 0.3m) ? "equals" : "does NOT equal")} {0.3m}\n");

/*
// Some special values; these exist in multiple numeric types
double notNumber = NaN;
double infiniteValue = double.PositiveInfinity;
double negativeInfinite = double.NegativeInfinity;
double infinitestimal = double.Epsilon;

double.IsNaN(notNumber);
double.IsInfinity(infiniteValue);
*/

// this unsafe block and the numeric types within only work if there's a True AllowUnsafeBlocks tag in the PropertyGroup of the .csproj file
unsafe
{
    Console.WriteLine($"Half uses {sizeof(Half)} bytes and can store numbers in the range {Half.MinValue:N0} to {Half.MaxValue:N0}");
    Console.WriteLine($"Int128 uses {sizeof(Int128)} bytes and can store numbers in the range {Int128.MinValue:N0} to {Int128.MaxValue:N0}\n");
}

// logical booleans...
bool happy = true;
bool sad = false;
