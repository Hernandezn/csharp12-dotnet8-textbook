
using Packt.Shared;

Person harry = new()
{
    Name = "Harry",
    Born = new(year: 2001, month: 3, day: 25, hour: 0, minute: 0, second: 0, offset: TimeSpan.Zero)
};
harry.WriteToConsole();



(Person lamech, Person adah, Person zillah) =
    (
        new() { Name = "Lamech" },
        new() { Name = "Adah" },
        new() { Name = "Zillah" }
    )
;

lamech.Marry(adah);
// Person.Marry(lamech, zillah);
if(lamech + zillah)
{
    WriteLine($"{lamech.Name} and {zillah.Name} successfully married");
}

lamech.OutputSpouses();
adah.OutputSpouses();
zillah.OutputSpouses();

Person baby1 = lamech.ProcreateWith(adah);
baby1.Name = "Jabal";
WriteLine($"{baby1.Name} was born on {baby1.Born}");

Person baby2 = Person.Procreate(zillah, lamech);
baby2.Name = "Tubalcain";

Person baby3 = lamech * adah;
baby3.Name = "Jubal";
Person baby4 = zillah * lamech;
baby4.Name = "Naamah";

adah.WriteChildrenToConsole();
zillah.WriteChildrenToConsole();
lamech.WriteChildrenToConsole();

for (int i = 0; i < lamech.Children.Count; i++)
{
    WriteLine(
        format: "   {0}'s child #{1} is named \"{2}\"",
        arg0: lamech.Name,
        arg1: i,
        arg2: lamech.Children[i].Name
    );
}
WriteLine();



System.Collections.Hashtable lookupObject = new();
lookupObject.Add(key: 1, value: "Alpha");
lookupObject.Add(key: 2, value: "Beta");
lookupObject.Add(key: 3, value: "Gamma");
lookupObject.Add(key: harry, value: "Delta");

int key = 2;
WriteLine(
    format: "Key {0} has value: {1}",
    arg0: key,
    arg1: lookupObject[key]
);

WriteLine(
    format: "Key {0} has value: {1}",
    arg0: harry,
    arg1: lookupObject[harry]
);



Dictionary<int, string> lookupIntString = new();
lookupIntString.Add(key: 1, value: "Alpha");
lookupIntString.Add(key: 2, value: "Beta");
lookupIntString.Add(key: 3, value: "Gamma");
lookupIntString.Add(key: 4, value: "Delta");

key = 3;
WriteLine(
    format: "Key {0} has value: {1}",
    arg0: key,
    arg1: lookupIntString[key]
);



// delegate field in Person.cs is assigned to point to the static method in Program.EventHandlers.cs
harry.Shout += Harry_Shout;
// it's like adding event listeners in javascript; they listen for anger levels above 3
harry.Shout += Harry_Shout_2;
harry.Poke();
harry.Poke();
harry.Poke();
harry.Poke();
WriteLine();



Person?[] people =
{
    null,
    new() { Name = "Simon" },
    new() { Name = "Jenny" },
    new() { Name = "Adam" },
    new() { Name = null },
    new() { Name = "Richard" }
};
OutputPeopleNames(
    people,
    "Initial list of people:"
);

Array.Sort(people);
OutputPeopleNames(
    people,
    "After sorting using Person's IComparable implementation:"
);



Array.Sort(people, new PersonComparer());
OutputPeopleNames(
    people,
    "After sorting using PersonComparer's IComparer implementation:"
);
WriteLine();



// value-type variable versus reference-type variable behavior
int a = 3;
int b = 3;
WriteLine($"a: {a}, b: {b}");
WriteLine($"a == b: {a == b}");

Person p1 = new() { Name = "Kevin" };
Person p2 = new() { Name = "Kevin" };
WriteLine($"p1: {p1}, p2: {p2}");
WriteLine($"p1.Name: {p1.Name}, p2.Name: {p2.Name}");
WriteLine($"p1 == p2: {p1 == p2}");
WriteLine($"p1.Name == p2.Name: {p1.Name == p2.Name}");

Person p3 = p1;
WriteLine($"p3: {p3}");
WriteLine($"p3.Name: {p3.Name}");
WriteLine($"p1 == p3: {p1 == p3}\n");



DisplacementVector dv1 = new(3, 5);
DisplacementVector dv2 = new(-2, 7);
DisplacementVector dv3 = dv1 + dv2;
WriteLine($"({dv1.X}, {dv1.Y}) + ({dv2.X}, {dv2.Y}) = ({dv3.X}, {dv3.Y})");

DisplacementVector dv4 = new();
WriteLine($"({dv4.X}, {dv4.Y})");

DisplacementVector dv5 = new(3, 5);
WriteLine($"dv1.Equals(dv5): {dv1.Equals(dv5)}");
WriteLine($"dv1 == dv5: {dv1 == dv5}"); // only works here because DisplacementVector is defined as a record struct
