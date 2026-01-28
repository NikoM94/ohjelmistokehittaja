using System.Text;

public static class Taulukot
{
    //T01
    public static string[] CreateShoppingList()
    {
        return ["omena", "leipä", "piimä"];
    }

    //T02
    public static string[] CreateFiveNames(string a, string b, string c, string d, string e)
    {
        return [a, b, c, d, e];
    }

    //T03
    public static int ArrLength(int[] arr)
    {
        return arr.Length;
    }

    //T04
    public static string[] AddName(string[] arr, string nameToAdd)
    {
        var newArr = new string[arr.Length + 1];

        for (int i = 0; i < arr.Length; i++)
        {
            newArr[i] = arr[i];
        }

        newArr[newArr.Length - 1] = nameToAdd;
        return newArr;
    }

    //T05
    public static int[] CombineArrays(int[] a, int[] b)
    {
        int[] newArr = new int[a.Length + b.Length];

        for (int i = 0; i < a.Length; i++)
        {
            newArr[i] = a[i];
        }

        for (int i = b.Length, j = 0; i < a.Length + b.Length; i++, j++)
        {
            newArr[i] = b[j];
        }

        return newArr;
    }

    //T06
    public static int[] EvenNumbers(int[] arr)
    {
        return [.. arr.Where(x => x % 2 == 0)];
    }

    // T07
    public static void SortAscending(int[] arr)
    {
        var sorted = false;
        while (!sorted)
        {
            sorted = true;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] > arr[i + 1])
                {
                    (arr[i + 1], arr[i]) = (arr[i], arr[i + 1]);
                    sorted = false;
                }
            }
        }
    }

    //T08
    public static int[] Reverse(int[] arr)
    {
        var reversed = new int[arr.Length];
        for (int i = arr.Length - 1, j = 0; i >= 0; i--, j++)
        {
            reversed[j] = arr[i];
        }
        return reversed;
    }


    //T09
    public static string ConvertToString(string[] arr)
    {
        var builder = new StringBuilder();
        foreach (var s in arr)
        {
            builder.Append(s).Append(", ");
        }
        return builder.ToString().Trim(' ').Trim(',');
    }

    //T10
    public static int[] RemoveAt(int[] arr, int at)
    {
        return [.. arr.Where(x => x != at)];
    }

    //T11
    public static int IndexOf(int[] arr, int value)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == value)
            {
                return i;
            }
        }
        return -1;
    }

    //T12
    public static int[] SliceFromTail(int[] arr, int amount)
    {
        var newArr = new int[amount];
        for (int i = 0, j = arr.Length - 1; i < newArr.Length; i++, j--)
        {
            newArr[i] = arr[j];
        }

        return [.. newArr.Reverse()];
    }

    //T13
    public static void SwapMiddle(int[] arr, int newValue)
    {
        if (arr.Length % 2 == 0)
        {
            return;
        }

        for (int i = 0; i < arr.Length; i++)
        {
            if (i == arr.Length / 2)
            {
                arr[i] = newValue;
            }
        }
    }

    //T14
    public static int SumArray(int[] arr)
    {
        return arr.Aggregate((sum, i) => sum + i);
    }

    //T15
    public static int Average(int[] arr)
    {
        return arr.Aggregate((sum, i) => sum + i) / arr.Length;
    }

    //T16
    public static int[] MultiplyElementsNTimes(int[] arr, int n)
    {
        var intList = new List<int>();

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < arr.Length; j++)
            {
                intList.Add(arr[j]);
            }
        }

        return [.. intList];
    }

    //T17
    public static int[] Unique(int[] arr)
    {
        return new HashSet<int>(arr).ToArray();
    }

    //T18
    public static void SwapHeadAndTail(int[] arr)
    {
        (arr[^1], arr[0]) = (arr[0], arr[^1]);
    }

    //T19
    public static void ToUpper(string[] toConvert)
    {
        for (int i = 0; i < toConvert.Length; i++)
        {
            var builder = new StringBuilder();
            for (int j = 0; j < toConvert[i].Length; j++)
            {
                if (!char.IsUpper(toConvert[i][j]))
                {
                    // -32 muuttaa ASCII-merkin pienestä isoksi
                    builder.Append((char)(toConvert[i][j] - 32));
                }
                else
                {
                    builder.Append(toConvert[i][j]);
                }
            }
            toConvert[i] = builder.ToString();
        }
    }

    //T20
    public static int[] RemoveSmallerThan(int[] arr, int bound)
    {
        var smallerThanBound = new List<int>();

        foreach (var item in arr)
        {
            if (item >= bound)
            {
                smallerThanBound.Add(item);
            }
        }
        return [.. smallerThanBound];
    }
}
