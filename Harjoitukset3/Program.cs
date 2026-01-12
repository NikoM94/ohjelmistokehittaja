using System.Numerics;

namespace Harjoitukset3;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine(AddNumbers(3, 5));
        // Console.WriteLine(ToFahrenheit(10));
        // Console.WriteLine(PerformOperations(8, 5));
        // Console.WriteLine(Modulus(5, 2));
        // Console.WriteLine(AskForName());
        // Console.WriteLine(AddNumbersWithInput());
        // Console.WriteLine(ToFahrenheitWithInput());
        // Console.WriteLine(PerformOperationsWithInput());
        // Console.WriteLine(ModulusWithInput());
        // KertoTaulu();
        // AskAge();
        // PrintNTimes(13);
        // SwapHeadAndTail();
        // Console.WriteLine(CheckNegativeOrPositive());
        // FindLongestString();
        // PrintOddNumbers();
        PrintDivisibleByThree();
    }
    
    static void PrintDivisibleByThree()
    {
        for (int i = 1; i < 100; i++)
        {
            if (i % 3 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }

    static void PrintOddNumbers()
    {
        for (int i = 0; i < 100; i++)
        {
            if (i % 2 != 0)
            {
                Console.WriteLine(i);
            }
        }
    }

    private static void FindLongestString()
    {
        Console.Write("Anna lause: ");
        string[] words =  Console.ReadLine().Split(" ");
        string maxLength = "";

        foreach (string word in words)
        {
            if (word.Length > maxLength.Length)
            {
                maxLength = word;
            }
        }

        Console.WriteLine(maxLength);
    }

private static string CheckNegativeOrPositive()
    {
        Console.Write("Anna luku 1: ");
        int a =  int.Parse(Console.ReadLine());
        Console.Write("Anna luku 2: ");
        int b =  int.Parse(Console.ReadLine());

        if (a > 0 && b > 0)
        {
            return "Molemmat ovat positiivisia";
        }
        
        if (a < 0 && b < 0)
        {
            return "Molemmt ovat negatiivisia";
        }

        return "Toinen on positiivinen ja toinen negatiivinen";
    }

    static void SwapHeadAndTail()
    {
        Console.Write("Anna sana: ");
        string? word =  Console.ReadLine();
        string swapped = word[^1] + word.Substring(1, word.Length - 2) + word[0];
        Console.WriteLine(swapped);
    }

    static void PrintNTimes(int n)
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"{n} ");
            }
            Console.WriteLine("");
            for (int j = 0; j < n; j++)
            {
                Console.Write($"{n}");
            }
            Console.WriteLine("");
        }
    }

static void AskAge()
    {
        Console.Write("Anna ikäsi: ");
        int age = int.Parse(Console.ReadLine());
        Console.WriteLine($"{age} - näytät ikäistäsi nuoremmalta");
    }

    static void KertoTaulu()
    {
        Console.Write("Anna kerrottava numero: ");
        int a = int.Parse(Console.ReadLine());
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i * a);
        }
}

    static int ModulusWithInput()
    {
        Console.Write("Anna numero 1: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Anna numero 2: ");
        int b = int.Parse(Console.ReadLine());
        return a % b;
    }

    static string PerformOperationsWithInput()
    {
        Console.Write("Anna numero 1: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Anna numero 2: ");
        double b = double.Parse(Console.ReadLine());
        return $"{a + b} / {a - b} / {a * b} / {a / b}";
    }

    static double ToFahrenheitWithInput()
    {
        Console.Write("Anna Celsius-arvo: ");
        int c = int.Parse(Console.ReadLine());
        return c * 1.8 + 32;
    }

    static int AddNumbersWithInput()
    {
        Console.Write("Anna numero 1: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Anna numero 2: ");
        int b = int.Parse(Console.ReadLine());
        return a + b;
    }

    static string AskForName()
    {
        Console.Write("Anna nimesi: ");
        string? name = Console.ReadLine();
        return $"Hei {name}";
    }

    static double Modulus(int a, int b)
    {
        return a % b;
    }

    static string PerformOperations(double a, double b)
    {
        return $"{a + b} / {a - b} / {a * b} / {a / b}";
    }

    static double ToFahrenheit(int c)
    {
        return c * 1.8 + 32;
    }

static int AddNumbers(int a, int b)
    {
        return a + b;
    }
}