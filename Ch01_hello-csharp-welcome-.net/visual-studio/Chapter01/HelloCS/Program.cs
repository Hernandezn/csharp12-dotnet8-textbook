
Console.WriteLine("Back to C#!");

string name = typeof(Program).Namespace ?? "None!"; // nullish coalescing
Console.WriteLine($"Namespace: {name}");

throw new Exception(); // reveals this program's implicit class in its stack trace
