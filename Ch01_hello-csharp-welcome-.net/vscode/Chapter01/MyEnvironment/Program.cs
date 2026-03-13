/*
    this project created using console command:

        dotnet new console -o MyEnvironment --use-program-main
*/

namespace MyEnvironment;

class Program
{
    static void Main(string[] args)
    {
        // string templating
        Console.WriteLine(
            $"Directory: {Environment.CurrentDirectory}\nOS Version: {Environment.OSVersion.VersionString}"
        );

        // a string arg insertion / format string syntax
        Console.WriteLine(
            "Namespace: {0}",
            typeof(Program).Namespace ?? "None!"
        );
    }
}
