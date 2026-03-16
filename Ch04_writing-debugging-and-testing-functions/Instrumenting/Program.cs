
using System.Diagnostics;
using Microsoft.Extensions.Configuration;

string logPath =
    Path.Combine(
        Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory),
        "log.txt"
    )
;
Console.WriteLine($"Writing to: {logPath}");
TextWriterTraceListener logFile = new(File.CreateText(logPath));
Trace.Listeners.Add(logFile);

// directive to only run this part when in debug mode
#if DEBUG 
// auto-calls Flush() on listeners to clear out data after writing it from buffer to file
// auto-flushing reduces performance, so it should only be used while debugging...
Trace.AutoFlush = true;
#endif

Debug.WriteLine("Debug watching!"); // debug statement only runs when in debug configuration
Trace.WriteLine("Trace watching!");

string settingsFile = "appsettings.json";
string settingsPath =
    Path.Combine(
        Directory.GetCurrentDirectory(),
        settingsFile
    )
;



Console.WriteLine("Processing: {0}", settingsPath);
Console.WriteLine("--{0} contents--", settingsFile);
Console.WriteLine(File.ReadAllText(settingsPath));
Console.WriteLine("----");

ConfigurationBuilder builder = new();
builder.SetBasePath(Directory.GetCurrentDirectory());
builder.AddJsonFile(
    settingsFile,
    optional: false,
    reloadOnChange: true
);

IConfigurationRoot configuration = builder.Build();
TraceSwitch ts = new(
    displayName: "PacktSwitch",
    description: "This switch is set via a JSON config."
);

configuration.GetSection("PacktSwitch").Bind(ts);

Console.WriteLine($"Trace switch value: {ts.Value}");
Console.WriteLine($"Trace switch level: {ts.Level}");

Trace.WriteLineIf(ts.TraceError, "Trace error"); // outputs at packtswitch value 1 and above
Trace.WriteLineIf(ts.TraceWarning, "Trace warning"); // outputs at packtswitch value 2 and above
Trace.WriteLineIf(ts.TraceInfo, "Trace information"); // outputs at packtswitch value 3 and above
Trace.WriteLineIf(ts.TraceVerbose, "Trace verbose"); // outputs at packtswitch value 4

int unitsInStock = 12;
LogSourceDetails(unitsInStock > 10);

Debug.Close();
Trace.Close();

Console.WriteLine("Press enter to exit.");
Console.ReadLine();
