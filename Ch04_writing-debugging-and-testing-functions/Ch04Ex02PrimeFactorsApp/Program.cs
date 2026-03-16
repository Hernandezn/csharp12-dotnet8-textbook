
using static Ch04Ex02PrimeFactorsLib.PrimeFactorsLib;

int input;
int counter = 0;

do
{
    Write("\nEnter a whole number from 2 to 1000, to find its prime factors > ");
    string rawInput = ReadLine()!;

    if (!int.TryParse(rawInput, out input))
    {
        counter++;
        WriteLine($"Input is not a valid int. {3 - counter} attempts left.");
    } else
    {
        break;
    }
}
while (counter < 3);

if (counter >= 3)
{
    WriteLine("Program exiting.");
}
else
{
    WriteLine($"\n{PrimeFactors(input)}\n");
}
