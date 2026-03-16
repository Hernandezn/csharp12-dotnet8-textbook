
using CallStackExceptionHandlingLib;
using static System.Console;

WriteLine("In Main");

Alpha();

void Alpha()
{
    WriteLine("In Alpha");
    Beta();
}

void Beta()
{
    WriteLine("In Beta");

    try
    {
        Processor.Gamma();
    }
    catch (IOException exc)
    {
        WriteLine($"Caught this: {exc.Message}");

        // LogException(exc); // hypothetical method that captures data on an exception thrown through here

        // throw exc; // throws from the current place in the program rather than from the exception's origin; call-stack lossy

        throw; // throws the given exception, as it was thrown from the exception's origin

        // throw new InvalidOperationException(
        //     message: "Invalid values. See inner exception",
        //     innerException: exc
        // );
    }
}
