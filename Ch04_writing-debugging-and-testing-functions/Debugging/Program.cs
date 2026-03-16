
Write("Enter a number > ");
string number = Console.ReadLine()!;

double a = double.Parse(number);
double b = 2.5;
double ans = Add(a, b);

Console.WriteLine($"{a} + {b} = {ans}");
Console.WriteLine("Press Enter to end app");
Console.ReadLine();

double Add(double a, double b)
{
    return a + b;
}
