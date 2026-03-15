
var colWidths = new int[]
{
    8,
    17,
    33,
    45
};
int totalWidth = 0;
foreach (int width in colWidths)
{
    totalWidth += width;
}

string horizontalRule = new('-', count: totalWidth);



// a method would be nice here, but we haven't gotten to that yet
WriteLine(horizontalRule);
string formatString = $"{{0, -{colWidths[0] - 1}}} {{1, -{colWidths[1]}}} {{2, {colWidths[2] - 1}}} {{3, {colWidths[3] - 1}}}";
WriteLine(
    formatString,
    "Type",
    "Byte(s) of memory",
    "Min",
    "Max"
);
WriteLine(horizontalRule);

// prep for numerics that overlap with the wrong headers
colWidths[1] -= 10;
colWidths[2] += 10;

// add numeric formats
formatString = $"{{0, -{colWidths[0] - 1}}} {{1, -{colWidths[1]}}} {{2, {colWidths[2] - 1}}} {{3, {colWidths[3] - 1}}}";

WriteLine(
    formatString,
    "sbyte",
    sizeof(sbyte),
    sbyte.MinValue,
    sbyte.MaxValue
);

WriteLine(
    formatString,
    "byte",
    sizeof(byte),
    byte.MinValue,
    byte.MaxValue
);

WriteLine(
    formatString,
    "short",
    sizeof(short),
    short.MinValue,
    short.MaxValue
);

WriteLine(
    formatString,
    "ushort",
    sizeof(ushort),
    ushort.MinValue,
    ushort.MaxValue
);

WriteLine(
    formatString,
    "int",
    sizeof(int),
    int.MinValue,
    int.MaxValue
);

WriteLine(
    formatString,
    "uint",
    sizeof(uint),
    uint.MinValue,
    uint.MaxValue
);

WriteLine(
    formatString,
    "long",
    sizeof(long),
    long.MinValue,
    long.MaxValue
);

WriteLine(
    formatString,
    "ulong",
    sizeof(ulong),
    ulong.MinValue,
    ulong.MaxValue
);

unsafe
{
    WriteLine(
        formatString,
        "Int128",
        sizeof(Int128),
        Int128.MinValue,
        Int128.MaxValue
    );

    WriteLine(
        formatString,
        "UInt128",
        sizeof(UInt128),
        UInt128.MinValue,
        UInt128.MaxValue
    );

    WriteLine(
        formatString,
        "Half",
        sizeof(Half),
        Half.MinValue,
        Half.MaxValue
    );
}

WriteLine(
    formatString,
    "float",
    sizeof(float),
    float.MinValue,
    float.MaxValue
);

WriteLine(
    formatString,
    "double",
    sizeof(double),
    double.MinValue,
    double.MaxValue
);

WriteLine(
    formatString,
    "decimal",
    sizeof(decimal),
    decimal.MinValue,
    decimal.MaxValue
);
