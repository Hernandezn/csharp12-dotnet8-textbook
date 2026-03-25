
using System; // to use String, while having Remove "System" in in the .csproj xml
using System.Xml.Linq; // to use XDocument

using Packt.Shared;

XDocument doc = new();

string s1 = "Hello";
String s2 = "World";
WriteLine($"{s1} {s2}");



WriteLine($"Environment.Is64BitProcess = {Environment.Is64BitProcess}");
WriteLine($"int.MaxValue = {int.MaxValue}");
WriteLine($"nint.MaxValue = {nint.MaxValue}");



Write("Enter a color value in hex: ");
string? hex = ReadLine();
WriteLine("{0} is a valid color value? {1}", hex, hex.IsValidHex());

Write("Enter the an XML element tag: ");
string? xmlTag = ReadLine();
WriteLine("{0} is a valid XML element tag? {1}", xmlTag, xmlTag.IsValidXmlTag());

Write("Enter a password: ");
string? password = ReadLine();
WriteLine("{0} is a valid password? {1}", password, password.IsValidPassword());
