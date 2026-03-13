
Console.WriteLine("C# again, from the top!");

string name = typeof(Program).Namespace ?? "None!"; // nullish coalescing operator
Console.WriteLine($"Namespace: {name}"); // string template
throw new Exception(); // to see the stack trace that includes the implicitly declared Program class
