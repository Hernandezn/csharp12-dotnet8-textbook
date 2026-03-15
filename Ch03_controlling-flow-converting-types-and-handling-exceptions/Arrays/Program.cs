
string[] names;

names = new string[4];

names[0] = "Kate";
names[1] = "Jack";
names[2] = "Rebecca";
names[3] = "Tom";

for (int i = 0; i < names.Length; i++)
{
    WriteLine($"{names[i]} is at position {i}.");
}
WriteLine();



string[] names2 = {"Kate", "Jack", "Rebecca", "Tom"};
foreach (string name in names2)
{
    WriteLine($"{name}");
}
WriteLine();



string[,] grid1 =
{
    {"Alpha", "Bravo", "Charlie", "Delta"},
    {"Anne", "Ben", "Charles", "Doug"},
    {"Aardvark", "Bear", "Cat", "Dog"}
};

WriteLine($"1st dimension, lower bound: {grid1.GetLowerBound(0)}");
WriteLine($"1st dimension, upper bound: {grid1.GetUpperBound(0)}");
WriteLine($"2nd dimension, lower bound: {grid1.GetLowerBound(1)}");
WriteLine($"2nd dimension, upper bound: {grid1.GetUpperBound(1)}\n");

for(int row = 0; row <= grid1.GetUpperBound(0); row++)
{
    for (int col = 0; col <= grid1.GetUpperBound(1); col++)
    {
        WriteLine($"Row {row}, Column {col}: {grid1[row, col]}");
    }
}
WriteLine();



string[][] jagged =
{
    new[] {"Alpha", "Beta", "Gamma"},
    new[] {"Ana", "Barry", "Camila", "Darian"},
    new[] {"Aardvark", "Bear"}
};
WriteLine(
    "Upper bound of the array of arrays is: {0}",
    arg0: jagged.GetUpperBound(0)
);
for (int array = 0; array <= jagged.GetUpperBound(0); array++)
{
    WriteLine(
        "Upper bound of array {0} is: {1}",
        arg0: array,
        arg1: jagged[array].GetUpperBound(0)
    );
}
WriteLine();

for(int row = 0; row <= jagged.GetUpperBound(0); row++)
{
    for (int col = 0; col <= jagged[row].GetUpperBound(0); col++)
    {
        WriteLine($"Row {row}, Column {col}: {jagged[row][col]}");
    }
}
WriteLine();



// pattern matching expressions for collections of items
int[] sequentials = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
int[] oneTwo = {1, 2};
int[] oneTwoTen = {1, 2, 10};
int[] oneTwoThreeTen = {1, 2, 3, 10};
int[] primes = {2, 3, 5, 7, 11, 13, 17, 19, 23};
int[] fibonacci = {0, 1, 1, 2, 3, 5, 8, 13, 21};
int[] empty = {};
int[] three = {9, 7, 5};
int[] six = {9, 7, 5, 4, 2, 10};

WriteLine($"{nameof(sequentials)}: {CheckSwitch(sequentials)}");
WriteLine($"{nameof(oneTwo)}: {CheckSwitch(oneTwo)}");
WriteLine($"{nameof(oneTwoTen)}: {CheckSwitch(oneTwoTen)}");
WriteLine($"{nameof(oneTwoThreeTen)}: {CheckSwitch(oneTwoThreeTen)}");
WriteLine($"{nameof(primes)}: {CheckSwitch(primes)}");
WriteLine($"{nameof(fibonacci)}: {CheckSwitch(fibonacci)}");
WriteLine($"{nameof(empty)}: {CheckSwitch(empty)}");
WriteLine($"{nameof(three)}: {CheckSwitch(three)}");
WriteLine($"{nameof(six)}: {CheckSwitch(six)}");

static string CheckSwitch(int[] values) => values switch // method lambda into switch
{
    [] => "empty array",
    [1, 2, _, 10] => "1, 2, one more number, and then 10",
    [1, 2, .., 10] => "1, 2, any amount of numbers (including none), and then the number 10",
    [1, 2] => "1, then 2",
    [int item1, int item2, int item3] => $"{item1}, then {item2}, then {item3}", // as long as they can all be referenced as ints
    [0, _] => "0, then an additional number",
    [0, ..] => "0, then any amount of numbers (including none)",
    [2, .. int[] others] => $"2, then {others.Length} more numbers", // as long as others can be referenced as any length of int array
    [..] => "any items in any amount in any order"
};
