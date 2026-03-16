
for (int x = 1; x <= 100; x++)
{
    string s = $"{(x % 3 == 0 ? "Fizz" : "")}{(x % 5 == 0 ? "Buzz" : "")}";

    if(string.IsNullOrEmpty(s))
    {
        Write(x);
    } 
    else
    {
        Write(s);
    }

    if(x != 100)
    {
        Write(", ");
    }
}
