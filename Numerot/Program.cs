namespace Numerot;

class Program
{
    static void Main(string[] args)
    {
        YPlusThree();
        YMinusTwo();
        YTimesFive();
        XDividedByY();
        XModuloY();
        XPlusEqualsY();
        XMinusEqualsY();
        XTimesEqualsY();
        XDividedByEqualsY();
    }


    private static void XDividedByEqualsY()
    {
        Console.WriteLine("Anna x:n arvo: ");
        int x = int.Parse(Console.ReadLine());
        Console.WriteLine("Anna y:n arvo: ");
        x /= int.Parse(Console.ReadLine());
        Console.WriteLine($"x /= y: {x}");
    }

    private static void XTimesEqualsY()
    {
        Console.WriteLine("Anna x:n arvo: ");
        int x = int.Parse(Console.ReadLine());
        Console.WriteLine("Anna y:n arvo: ");
        x *= int.Parse(Console.ReadLine());
        Console.WriteLine($"x *= y: {x}");
    }

    private static void XMinusEqualsY()
    {
        Console.WriteLine("Anna x:n arvo: ");
        int x = int.Parse(Console.ReadLine());
        Console.WriteLine("Anna y:n arvo: ");
        x -= int.Parse(Console.ReadLine());
        Console.WriteLine($"x -= y: {x}");
    }

    private static void XPlusEqualsY()
    {
        Console.WriteLine("Anna x:n arvo: ");
        int x = int.Parse(Console.ReadLine());
        Console.WriteLine("Anna y:n arvo: ");
        x += int.Parse(Console.ReadLine());
        Console.WriteLine($"x += y: {x}");
    }

    private static void XModuloY()
    {
        Console.WriteLine("Anna x:n arvo: ");
        int x = int.Parse(Console.ReadLine());
        Console.WriteLine("Anna y:n arvo: ");
        int y = int.Parse(Console.ReadLine());
        Console.WriteLine($"x % y: {x % y}");
    }

    private static void XDividedByY()
    {
        Console.WriteLine("Anna x:n arvo: ");
        int x = int.Parse(Console.ReadLine());
        Console.WriteLine("Anna y:n arvo: ");
        int y = int.Parse(Console.ReadLine());
        Console.WriteLine($"x / y: {x / y}");
    }

    private static void YPlusThree()
    {
        Console.WriteLine("Anna y:n arvo: ");
        int y = int.Parse(Console.ReadLine());
        Console.WriteLine($"y + 3: {y + 3}");
    }

    private static void YMinusTwo()
    {
        Console.WriteLine("Anna y:n arvo: ");
        int y = int.Parse(Console.ReadLine());
        Console.WriteLine($"y - 2: {y - 2}");
    }

    private static void YTimesFive()
    {
        Console.WriteLine("Anna y:n arvo: ");
        int y = int.Parse(Console.ReadLine());
        Console.WriteLine($"y * 5: {y * 5}");
    }
}