namespace Ch04Ex02PrimeFactorsLib;

public class PrimeFactorsLib
{
    public static string PrimeFactors(int num)
    {
        if (num < 2)
        {
            return $"Only numbers down to 2 are handled. Input number: {num}";
        }
        else if (num > 1000)
        {
            return $"Only numbers up to 1000 are handled. Input number: {num}";
        }
        else if (IsPrime(num))
        {
            return $"Prime factor of {num} is {num}";
        }

        string result = $"Prime factors of {num} are ";

        List<int> factors = [];
        int currentPrime = 1;

        do
        {
            // iterates through each next prime
            currentPrime = NextPrime(currentPrime);

            // adds all instances of the current prime
            while (num % currentPrime == 0)
            {
                factors.Add(currentPrime);

                num /= currentPrime;
            }
        }
        while (num != 1);

        // list was created smallest to largest, but want result to be largest to smallest
        for (int i = factors.Count - 1; i >= 0; i--)
        {
            result += factors[i];

            if (i != 0)
            {
                result += " x ";
            }
        }

        return result;
    }

    private static int NextPrime(int num)
    {
        if (num < 2)
        {
            return 2;
        }
        else if (num == 2)
        {
            return 3;
        }

        // adds 1 if even, adds 2 if odd
        num += num % 2 + 1;

        while (!IsPrime(num))
        {
            num += 2;
        }

        return num;
    }

    // checks if the input number is prime
    private static bool IsPrime(int num)
    {
        if (num < 2)
        {
            return false;
        }
        else if (num == 2 || num == 3)
        {
            return true;
        }
        else if (num % 2 == 0)
        {
            return false;
        }

        // same sqrt as in java & js ...
        int limit = (int)Math.Sqrt(num) + 1;

        for (int i = 3; i <= limit; i += 2)
        {
            if (num % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}
