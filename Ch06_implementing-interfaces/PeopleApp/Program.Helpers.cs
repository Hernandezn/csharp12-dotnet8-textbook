
using Packt.Shared;

partial class Program
{
    private static void OutputPeopleNames (
        IEnumerable<Person?> people, string title
    )
    {
        WriteLine(title);

        foreach(Person? p in people)
        {
            WriteLine(
                " {0}",

                // ternary chain with nullish coalescing; is p null? "<null> Person" if true and p.Name if false; coerces to "<null> Name" if p.Name is null
                p is null ? "<null> Person" : p.Name ?? "<null> Name"
            );
        }
    }
}
