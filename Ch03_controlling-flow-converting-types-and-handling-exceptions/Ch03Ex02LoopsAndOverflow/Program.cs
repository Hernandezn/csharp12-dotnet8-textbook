
WriteLine("(byte max is {0})", byte.MaxValue);

try
{
    checked
    {
        int max = 500;
        for(byte i = 0; i < max; i++)
        {
            WriteLine(i);
        }
    }   
} 
catch (OverflowException)
{
    WriteLine("The counter overflowed!");
}
