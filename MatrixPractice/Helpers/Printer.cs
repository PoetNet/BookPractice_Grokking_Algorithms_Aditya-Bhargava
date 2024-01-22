using System.Text;

namespace Grokking_Algorithms.MatrixPractice.Helpers;

public class Printer
{
    public static string GetArrayAsString(int[] arr)
    {
        StringBuilder stringBuilder = new();
        stringBuilder.Append("[");
        for (int i = 0; i < arr.Length; i++)
        {
            stringBuilder.Append($" {arr[i]}");
        }
        stringBuilder.Append(" ]");

        return stringBuilder.ToString();
    }
}