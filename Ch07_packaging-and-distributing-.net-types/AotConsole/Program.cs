
using System.Globalization; // for CultureInfo
using System.Reflection; // for AssemblyName
using System.Reflection.Emit; // for AssemblyBuilder

WriteLine("This is an ahead-of-time (AOT) compiled application");
WriteLine("Current culture: {0}", CultureInfo.CurrentCulture);
WriteLine("OS version: {0}", Environment.OSVersion);
Write("Press any key to exit");
ReadKey(intercept: true);



// AssemblyBuilder ab = AssemblyBuilder.DefineDynamicAssembly(
//     new AssemblyName("MyAssembly"),
//     AssemblyBuilderAccess.Run
// );




