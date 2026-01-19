using System.Text;

namespace LumoTehtavat;

class Program
{
    static void Main(string[] args)
    {
        // PrintSorted();
        // PrintToUpper();
        // PrintReversed();
        PrintConvertedToString();
    }

    private static void PrintConvertedToString()
    {
        var toPrint = new string[] { "Matti", "Anna", "Eeva" };
        Console.WriteLine(Taulukot.ConvertToString(toPrint));
    }

    private static void PrintReversed()
    {
        var toPrint = new int[] { 5, 4, 3, 2, 1 };
        var reversed = Taulukot.Reverse(toPrint);
        var builder = new StringBuilder();
        builder.Append('[');
        foreach (var item in reversed)
        {
            builder.Append($"{item}, ");
        }
        Console.WriteLine($"{builder.ToString().Trim(' ').Trim(',')}]");
    }

    private static void PrintToUpper()
    {
        var toPrint = new string[] { "Matti", "Anna", "Eeva" };
        Taulukot.ToUpper(toPrint);
        var builder = new StringBuilder();
        builder.Append('[');
        foreach (var item in toPrint)
        {
            builder.Append($"{item}, ");
        }
        Console.WriteLine($"{builder.ToString().Trim(' ').Trim(',')}]");
    }

    private static void PrintSorted()
    {
        var toSort = new int[] { 5, 2, 9, 1, 5, 8, 3 };
        Taulukot.SortAscending(toSort);
        var builder = new StringBuilder();
        builder.Append('[');
        foreach (var item in toSort)
        {
            builder.Append($"{item}, ");
        }
        Console.WriteLine($"{builder.ToString().Trim(' ').Trim(',')}]");
    }
}
