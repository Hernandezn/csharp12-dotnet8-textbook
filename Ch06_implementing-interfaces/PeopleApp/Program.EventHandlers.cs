
using Packt.Shared;

partial class Program
{
    private static void Harry_Shout(object? sender, EventArgs eventArgs)
    {
        if (sender is null) return;

        if (sender is not Person p) return;

        WriteLine($"{p.Name} is this angry: {p.AngerLevel}");
    }

    private static void Harry_Shout_2(object? sender, EventArgs eventArgs)
    {
        WriteLine("Stop it!");
    }
}
