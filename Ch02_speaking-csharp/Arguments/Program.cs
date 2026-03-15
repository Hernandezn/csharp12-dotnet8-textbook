

using System.Runtime.Serialization;
using System.Text;

WriteLine($"There are {args.Length} arguments.");
foreach (string arg in args) 
{
    WriteLine(arg);
}
WriteLine();



if(args.Length < 3)
{
    WriteLine("You must specify two colors and cursor size.");
    WriteLine("dotnet run red yellow 50");
    return;
}

// static members of the System.Console class
ForegroundColor = (ConsoleColor)Enum.Parse(
    enumType: typeof(ConsoleColor),
    value: args[0],
    ignoreCase: true
);
BackgroundColor = (ConsoleColor)Enum.Parse(
    enumType: typeof(ConsoleColor),
    value: args[1],
    ignoreCase: true
);
try
{
    CursorSize = int.Parse(args[2]);
}
catch (PlatformNotSupportedException)
{
    WriteLine("The current platform does not support changing the cursor size.");
}



// Platform-specific-compile directives
#if NET7_0_ANDROID
// Compile statements that only work on Android
#elif NET7_0_IOS
// Compile statements taht only work on iOS
#else
// Compile statements for everywhere else
#endif
