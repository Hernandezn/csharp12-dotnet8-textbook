
using static Ch04Ex02PrimeFactorsLib.PrimeFactorsLib;

namespace Ch04Ex02PrimeFactorsTests;

public class UnitTest1
{
    [Fact]
    public void Test0()
    {
        string expected = "Only numbers down to 2 are handled. Input number: 0";

        Assert.Equal(expected, PrimeFactors(0));
    }

    [Fact]
    public void Test1()
    {
        string expected = "Only numbers down to 2 are handled. Input number: 1";

        Assert.Equal(expected, PrimeFactors(1));
    }

    [Fact]
    public void Test2()
    {
        string expected = "Prime factor of 2 is 2";

        Assert.Equal(expected, PrimeFactors(2));
    }

    [Fact]
    public void Test4()
    {
        string expected = "Prime factors of 4 are 2 x 2";

        Assert.Equal(expected, PrimeFactors(4));
    }

    [Fact]
    public void Test7()
    {
        string expected = "Prime factor of 7 is 7";

        Assert.Equal(expected, PrimeFactors(7));
    }

    [Fact]
    public void Test30()
    {
        string expected = "Prime factors of 30 are 5 x 3 x 2";

        Assert.Equal(expected, PrimeFactors(30));
    }

    [Fact]
    public void Test40()
    {
        string expected = "Prime factors of 40 are 5 x 2 x 2 x 2";

        Assert.Equal(expected, PrimeFactors(40));
    }

    [Fact]
    public void Test50()
    {
        string expected = "Prime factors of 50 are 5 x 5 x 2";

        Assert.Equal(expected, PrimeFactors(50));
    }

    [Fact]
    public void Test1000()
    {
        string expected = "Prime factors of 1000 are 5 x 5 x 5 x 2 x 2 x 2";

        Assert.Equal(expected, PrimeFactors(1000));
    }

    [Fact]
    public void Test1001()
    {
        string expected = "Only numbers up to 1000 are handled. Input number: 1001";

        Assert.Equal(expected, PrimeFactors(1001));
    }

    [Fact]
    public void Test91()
    {
        string expected = "Prime factors of 91 are 13 x 7";

        Assert.Equal(expected, PrimeFactors(91));
    }

    [Fact]
    public void Test997()
    {
        string expected = "Prime factor of 997 is 997";

        Assert.Equal(expected, PrimeFactors(997));
    }

    [Fact]
    public void TestMin()
    {
        string expected = $"Only numbers down to 2 are handled. Input number: {int.MinValue}";

        Assert.Equal(expected, PrimeFactors(int.MinValue));
    }

    [Fact]
    public void TestMax()
    {
        string expected = $"Only numbers up to 1000 are handled. Input number: {int.MaxValue}";

        Assert.Equal(expected, PrimeFactors(int.MaxValue));
    }
}
