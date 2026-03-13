namespace MyEnvironment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // a string templating syntax
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
}
