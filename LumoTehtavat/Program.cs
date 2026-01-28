using System.Text;

namespace LumoTehtavat;

class Program
{
    static void Main(string[] args)
    {
        // PrintToUpper();
        // PrintShoppingList();
        // PrintFiveNames();
        // PrintArrLength();
        // PrintAddName();
        // PrintCombineArrays();
        // Taulukot.PrintEvenNumbers([1, 2, 3, 4, 5, 6, 7, 8, 9, 10]);
        // PrintSortAscending();
        // PrintReversed();
        // PrintConvertedToString();
        // PrintRemoveAt();
        // PrintSumArray();
        // PrintIndexOf();
        // PrintSliceFromTail();
        // PrintSwapMiddle();
        // PrintAverageArray();
        // PrintMultiplyElementsNTimes();
        // PrintUnique();
        // PrintRemoveSmallerThan();
        PrintSwapHeadAndTail();
    }

    private static void PrintSwapHeadAndTail()
    {
        int[] ints = [1, 2, 3, 4, 5];
        Console.WriteLine($"Before swapping first and last element: {ToString(ints)} ");
        Taulukot.SwapHeadAndTail(ints);
        Console.WriteLine($"First and last element swapped: {ToString(ints)}");
    }

    private static void PrintRemoveSmallerThan()
    {
        int[] ints = [1, 2, 3, 4, 5];
        int bound = 4;
        int[] removed = Taulukot.RemoveSmallerThan(ints, bound);
        Console.WriteLine($"Array with all numbers smaller than {bound} removed: {ToString(removed)}");
    }

    private static void PrintUnique()
    {
        int[] ints = [1, 2, 2, 3, 4, 4, 5];
        Console.WriteLine($"Before removing duplicates: {ToString(ints)}");
        int[] unique = Taulukot.Unique(ints);
        Console.WriteLine($"After removing duplicates: {ToString(unique)}");

    }

    private static void PrintMultiplyElementsNTimes()
    {
        int[] ints = [1, 2, 3];
        int times = 3;
        Console.WriteLine($"Before multiplying {times} times: {ToString(ints)}");
        int[] multiplied = Taulukot.MultiplyElementsNTimes(ints, 3);
        Console.WriteLine($"After multiplying {times} times: {ToString(multiplied)}");
    }

    private static void PrintAverageArray()
    {
        int[] ints = [1, 2, 3, 4, 5];
        int avg = Taulukot.Average(ints);
        Console.WriteLine($"Elements of array {ToString(ints)} averages to {avg}");
    }

    private static void PrintSwapMiddle()
    {
        int[] ints = [1, 2, 3, 4, 5];
        int newValue = 6;
        Console.WriteLine($"Before swapping the middle value to {newValue}: {ToString(ints)}");
        Taulukot.SwapMiddle(ints, newValue);
        Console.WriteLine($"After swap: {ToString(ints)}");
    }

    private static void PrintSliceFromTail()
    {
        int[] ints = [1, 2, 3, 4, 5];
        int amount = 2;
        int[] sliced = Taulukot.SliceFromTail(ints, amount);
        Console.WriteLine($"{amount} elements from the end of {ToString(ints)}: {ToString(sliced)}");
    }

    private static void PrintIndexOf()
    {
        int[] ints = [1, 2, 3, 4, 5];
        int value = 2;
        int indexOf = Taulukot.IndexOf(ints, value);
        if (indexOf == -1)
        {
            Console.WriteLine($"Value {value} does not exist in array {ToString(ints)}");
        }
        else
        {
            Console.WriteLine($"Value {value} found at index: {indexOf} of {ToString(ints)}");
        }
    }

    private static void PrintSumArray()
    {
        int[] arr = [1, 2, 3, 4, 5];
        Console.WriteLine($"The elements in the array {ToString(arr)} sums to {Taulukot.SumArray(arr)}");
    }

    private static void PrintRemoveAt()
    {
        int[] result = Taulukot.RemoveAt([1, 2, 3, 4, 5], 2);
        Console.WriteLine(ToString(result));
    }

    private static void PrintShoppingList()
    {
        var shoppingList = Taulukot.CreateShoppingList();
        Console.WriteLine(ToString(shoppingList));
    }

    private static void PrintFiveNames()
    {
        string[] names = Taulukot.CreateFiveNames("Aino", "Aila", "Aleksi", "Aapo", "Akseli");
        Console.WriteLine(ToString(names));
    }

    private static void PrintArrLength()
    {
        int[] example = [1, 2, 3, 4, 5];
        Console.WriteLine($"Array {ToString(example)} is of length: {Taulukot.ArrLength(example)}");
    }

    private static void PrintAddName()
    {
        string[] names = ["Matti", "Anna", "Eeva"];
        Taulukot.AddName(names, "Aino");
        Console.WriteLine(ToString(names));
    }

    private static void PrintCombineArrays()
    {
        int[] a = [1, 2, 3];
        int[] b = [4, 5, 6];
        int[] combined = Taulukot.CombineArrays(a, b);
        Console.WriteLine(ToString(combined));
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
        Console.WriteLine(ToString(reversed));
    }

    private static void PrintToUpper()
    {
        var toUpper = new string[] { "Matti", "Anna", "Eeva" };
        Taulukot.ToUpper(toUpper);
        Console.WriteLine(ToString(toUpper));
    }

    private static void PrintSortAscending()
    {
        var toSort = new int[] { 5, 2, 9, 1, 5, 8, 3 };
        Taulukot.SortAscending(toSort);
        Console.WriteLine(ToString(toSort));
    }

    private static string ToString(int[] toPrint)
    {
        var builder = new StringBuilder();
        builder.Append('[');
        foreach (var item in toPrint)
        {
            builder.Append($"{item}, ");
        }
        return $"{builder.ToString().Trim(' ').Trim(',')}]";

    }


    private static string ToString(string[] toPrint)
    {
        var builder = new StringBuilder();
        builder.Append('[');
        foreach (var item in toPrint)
        {
            builder.Append($"{item}, ");
        }
        return $"{builder.ToString().Trim(' ').Trim(',')}]";
    }
}
