
// numbered positional arguments - the {0}, {1}, etc. that might be seen in strings
int appleCount = 12;
decimal unitPrice = 0.35M;

// arg0, arg1, arg2 can be named; any beyond this must be unnamed args (varargs overloaded method?)
Console.WriteLine(
    format: "{0} apples cost {1:C}",
    arg0: appleCount,
    arg1: unitPrice * appleCount
);

string formatted = string.Format(
    format: "{0} apples cost {1:C}",
    arg0: appleCount,
    arg1: unitPrice * appleCount
);
// WriteToFile(formatted); // a hypothetical method that doesn't natively parse numbered positional args

// mixing named with unnamed args
Console.WriteLine(
    "{0} {1} lived in {2}.",
    arg0: "Roger",
    arg1: "Cevung",
    arg2: "Stockholm"
);

// can use multiple of the same arg, like how there are 2 instances of {2} in this format string
Console.WriteLine(
    "{0} {1} lived in {2} and worked in the {3} team at {4} {2}.",
    "Roger",
    "Cevung",
    "Stockholm",
    "Safety",
    "Optimized Experiences"
);
