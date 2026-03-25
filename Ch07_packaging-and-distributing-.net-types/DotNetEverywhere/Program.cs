
WriteLine("Runnable everywhere!");
WriteLine($"OS Version is {Environment.OSVersion}");

if (OperatingSystem.IsMacOS())
{
    WriteLine("I am MacOS");
}
else if (OperatingSystem.IsWindowsVersionAtLeast(10, 22000))
{
    WriteLine("I am Windows 11");
}
else if (OperatingSystem.IsWindowsVersionAtLeast(10))
{
    WriteLine("I am Windows 10");
}
else
{
    WriteLine("I am a miscellaneous OS");
}
WriteLine("Press any key");
ReadKey(intercept: true);
