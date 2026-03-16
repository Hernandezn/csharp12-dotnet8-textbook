
int x = 3;
int y = 2 + ++x;
// should be (4, 6); y increments x from 3 to 4, then adds that to 2
Check(x, y);

x = 3 << 2;
y = 10 >> 1;
// should be (12, 5); bitshift left multiplies by 2 (twice for << 2), bitshift right divides by 2 (once for >> 1)
Check(x, y);

x = 10 & 8; // 00001010 & 00001000
y = 10 | 7; // 00001010 | 00000111
// should be (8, 15); only the 8 bit flips on for x, and all bits below 16 flip on for y
Check(x, y);

static void Check(int a, int b)
{
    Console.WriteLine($"({a}, {b})");
}
