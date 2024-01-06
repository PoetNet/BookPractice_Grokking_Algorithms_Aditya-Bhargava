namespace Grokking_Algorithms.Exercises;

public static class SortingChapter3
{
    /// <summary>
    /// Exercise 4.1 
    /// Write out the code for the earlier sum function.
    /// </summary>
    /// <param name="arr"></param>
    /// <returns>Sum of all numbers in the array</returns>
    public static int SumRecursive(int[] arr)
    {
        int total;
        if (arr.Length == 1)
        {
            total = arr[0];
            return total;
        }

        int number = arr[arr.Length - 1];
        Array.Resize(ref arr, arr.Length-1);

        total = number + SumRecursive(arr);
        return total;
    }
}
