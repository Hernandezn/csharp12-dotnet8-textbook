
namespace Packt.Shared;

// exercise 5.2

// official documentation references from the chapter:
// https://github.com/markjprice/cs12dotnet8/blob/main/docs/book-links.md#chapter-5---building-your-own-types-with-object-oriented-programming
public class Car
{
    public int Wheels { get; set; }

    public bool IsEV { get; set; }

    public void Start()
    {
        Console.WriteLine("Starting...");
    }
}
