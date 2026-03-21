
using Packt.Shared;

int cantBeNull = 4;
// cantBeNull = null; // won't compile because int is a non-nullable value type

WriteLine(cantBeNull);

int? couldBeNull = null;
WriteLine(couldBeNull);
WriteLine(couldBeNull.GetValueOrDefault());

couldBeNull = 7;
WriteLine(couldBeNull);
WriteLine(couldBeNull.GetValueOrDefault());

Nullable<int> couldAlsoBeNull = null; // same sa declaring it an "int?" value
couldAlsoBeNull = 9;
WriteLine(couldAlsoBeNull);
WriteLine();



Address address = new(city: "London")
{
    Building = null,
    Street = null!, // warning suppression with the null-forgiving operator
    Region = "UK"
};



WriteLine(address.Building?.Length);
if (address.Street is not null)
{
    WriteLine(address.Street.Length);
}
