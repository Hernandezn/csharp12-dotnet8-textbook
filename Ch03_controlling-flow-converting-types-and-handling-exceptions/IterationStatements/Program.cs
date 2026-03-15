
int x = 0;
while (x < 10)
{
    Write($"{x} ");
    x++;
}
WriteLine();

string? actualPassword = "Pa$$word";
string? password = null;

int counter = 0;
do
{
    Write("Enter your password: ");
    // password = ReadLine();

    counter++;
}
while (counter < 3 && password != actualPassword);

if (password == actualPassword)
{
    WriteLine("Correct!");
}
else
{
    WriteLine("Maximum 3 attempts allowed.");
}
WriteLine();



for (int y = 1; y <= 10; y++)
{
    Write($"{y} ");
}
WriteLine();
for (int y = 0; y <= 10; y += 3)
{
    Write($"{y} ");
}
WriteLine();



string[] names = {  "Adam", "Barry", "Cecilia" };
foreach (string name in names)
{
    WriteLine($"\"{name}\" has {name.Length} characters.");
}

// // equivalent statement to the foreach above:
// IEnumerator e = names.GetEnumerator();
// while (e.MoveNext())
// {
//     string name = (string)e.Current; // Current is a read-only property of a foreach-iterable type's Enumerator object
//     WriteLine($"\"{name}\" has {name.Length} characters.");
// }
