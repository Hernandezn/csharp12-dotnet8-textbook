
using System.Diagnostics;
using System.Runtime.CompilerServices;

partial class Program
{
    static void LogSourceDetails(
        bool condition,
        [CallerFilePath] string filepath = "", // name of the file that's calling this method
        [CallerMemberName] string member = "", // name of the method that's calling this method
        [CallerLineNumber] int line = 0, // line number in the file that's calling this method
        [CallerArgumentExpression(nameof(condition))] string expression = "" // the expression passed into this method as the "condition" argument
    )
    {
        Trace.WriteLine(
            string.Format(
                "[{0}]\n [{1}] on line [{2}]. Expression: {3}",
                filepath,
                member,
                line,
                expression
            )
        );
    }
}
