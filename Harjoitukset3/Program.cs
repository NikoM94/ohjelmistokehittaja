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
        KertoTaulu();
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