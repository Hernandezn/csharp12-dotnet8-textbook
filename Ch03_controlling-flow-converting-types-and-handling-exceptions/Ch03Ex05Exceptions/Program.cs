
Write("Enter a number between 0 and 255, inclusive > ");
string input1 = ReadLine()!;

Write("Enter another number between 0 and 255, inclusive > ");
string input2 = ReadLine()!;

try
{
    byte result = (byte) (byte.Parse(input1) / byte.Parse(input2));

    WriteLine($"{input1} divided by {input2} is {result}");
}
catch (OverflowException)
{
    WriteLine("Overflow Exception - the value was too large or too small. Did you choose a number between 0 and 255?");
}
catch (FormatException)
{
    WriteLine("Format Exception - inputs were in an incorrect format for use as numbers.");
}
catch (Exception exc)
{
    WriteLine($"{exc.GetType()}: {exc.Message}");
}
