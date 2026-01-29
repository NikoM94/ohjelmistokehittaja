public class Silmukat
{
    //S01
    public static double CalculateInterest(double price, double interest, int months)
    {
        double monthlyBeforeInterest = price / months;
        double totalPayment = price;
        double interestConversion = interest / 100;
        Console.WriteLine(interestConversion);
        for (int i = 0; i < months; i++)
        {
            totalPayment += price * interestConversion;
        }
        return totalPayment;
    }

    //S02
    public static int Factorial(int n)
    {
        if (n == 1)
        {
            return 1;
        }
        else
        {
            return n * Factorial(n - 1);
        }
    }

    //S03
    public static int FindFirst(int[] arr, int x)
    {
        return Array.Find(arr, (y) => y == x);
    }

    //S04
    public static string ReverseString(string s)
    {
        char[] c = s.ToCharArray();
        Array.Reverse(c);
        return new string(c);
    }

    //S05
    public static int Maximum(int[] arr)
    {
        int max = 0;
        foreach (var item in arr)
        {
            if (item > max)
            {
                max = item;
            }
        }
        return max;
    }

    //S06
    public static double Average(int[] arr)
    {
        return (double)arr.Aggregate((sum, i) => sum + i) / arr.Length;
    }

    //S07
    public static char[] ToUpperCase(char[] arr)
    {
        return [.. arr.Select(c => (char)(c - 32))];
    }

    //S08
    public static int FindSeventhOdd(int[] arr)
    {
        int count = 0;
        int seventh = 1;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] % 2 != 0)
            {
                seventh = arr[i];
                count++;
            }
            if (count == 7)
            {
                return seventh;
            }
        }
        return 0;
    }

    //S09
    public static int FindSecondLargest(int[] arr)
    {
        return new HashSet<int>(arr).Order().ToArray()[^2];
    }

    //S10
    public static void FizzBuzz()
    {
        for (int i = 1; i <= 100; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                Console.WriteLine($"FizzBuzz: {i}");
            }
            else if (i % 3 == 0)
            {
                Console.WriteLine($"Fizz: {i}");
            }
            else if (i % 5 == 0)
            {
                Console.WriteLine($"Buzz: {i}");
            }
        }
    }

    //S11
    public static int Fib(int n)
    {
        if (n <= 2)
        {
            return 1;
        }
        else
        {
            return Fib(n - 1) + Fib(n - 2);
        }
    }
    //S12
    public static bool Palindrome(string s)
    {
        return ReverseString(s) == s;
    }

    //S13
    public static int EvenFib(int n)
    {
        int count = 0, curr = 2, prev = 1, temp;
        while (count <= n)
        {
            temp = prev;
            prev = curr;
            curr += temp;
            if (curr % 2 == 0) count++;
        }
        return curr;
    }

    //S14
    public static int OddFib(int n)
    {
        int count = 0, curr = 2, prev = 1, temp;
        while (count < n - 1)
        {
            temp = prev;
            prev = curr;
            curr += temp;
            if (curr % 2 != 0) count++;
        }
        return curr;
    }

    //S15
    public static int GCF(int a, int b)
    {
        var factorsA = FindFactors(a);
        var factorsB = FindFactors(b);
        var longerList = factorsA.Count > factorsB.Count ? factorsA : factorsB;
        var shorterList = factorsA.Count > factorsB.Count ? factorsB : factorsA;
        return longerList.Where(shorterList.Contains).Order().ToArray()[^1];
    }
    private static List<int> FindFactors(int a)
    {
        var factors = new List<int>();
        for (int i = a; i > 0; i--)
        {
            if (a % i == 0)
            {
                factors.Add(i);
            }
        }
        return factors;
    }

    //S16
    public static void CSV()
    {
        Console.Write("Enter a list of comma separated integers for example: 1,2,3,4,5: ");
        string? input = Console.ReadLine();
        string[] splits = input.Split(',');
        foreach (var item in splits)
        {
            Console.Write($"{item} ");
        }
        Console.WriteLine();
    }
}
