
WriteLine("Before parsing");
Write("What is your age? > ");
string? input = ReadLine();

if(input is null)
{
    WriteLine("No input detected. Exiting...");
    return;
}

try
{
    int age = int.Parse(input!); // null-forgiving operator; only affects compiler warnings about null safety
    WriteLine($"You are {age} years old");
}
catch (OverflowException)
{
    WriteLine("Your age is a valid number, but it is either too large or too small to be a valid age.");
}
catch (FormatException)
{
    WriteLine("The age you entered is not a valid number.");
}
catch (Exception exc)
{
    WriteLine($"{exc.GetType()} says {exc.Message}");
}
WriteLine("After parsing\n");



Write("Enter an amount > ");
string amount = ReadLine()!;
if(string.IsNullOrEmpty(amount)) amount = "";

try
{
    decimal amountValue = decimal.Parse(amount);
    WriteLine($"Amount formatted as currency: {amountValue}");
}
catch (FormatException) when (amount.Contains('$')) // watch with "when" query filter
{
    WriteLine("Amounts cannot use a dollar sign!");
}
catch (FormatException)
{
    WriteLine("Amounts must only contain digits!");
}
catch (Exception)
{
    //
}
WriteLine();



int x = int.MaxValue - 1;
WriteLine($"Initial value: {x}");

int counter = 0;

try {
    checked // detects when the integer overflows and throws the appropriate overflow exception, instead of letting it overflow silently
    {
        do
        {
            x++;
            WriteLine($"After incrementing: {x}");
            counter++;
        }
        while (counter < 3);
    }
}
catch (OverflowException)
{
    WriteLine("Overflow detected and contained.");
}
WriteLine();



unchecked
{
    int y = int.MaxValue + 1; // wouldn't compile outside the "unchecked" block, as a compile-time check detects the overflow

    WriteLine($"Initial value: {y}");
    y--;
    WriteLine($"After decrementing: {y}");
    y--;
    WriteLine($"After decrementing: {y}");
}

