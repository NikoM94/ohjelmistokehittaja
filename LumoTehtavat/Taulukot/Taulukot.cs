using System.Text;

public static class Taulukot
{
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
}
