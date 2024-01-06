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
        if (CountRecursive(arr) < 2)
        {
            total = arr[0];
            return total;
        }

        int number = arr[CountRecursive(arr) - 1];
        Array.Resize(ref arr, CountRecursive(arr) - 1);

        total = number + SumRecursive(arr);
        return total;
    }

    /// <summary>
    /// Exercise 4.2 
    /// Write a recursive function to count the number of items in a list.
    /// </summary>
    /// <param name="arr"></param>
    /// <param name="index"></param>
    /// <returns>Count the number of items in an array</returns>
    public static int CountRecursive(int[] arr, int index = 0)
    {
        int count;
        int number;
        try
        {
            number = arr[index];
            count = 1 + CountRecursive(arr, index + 1);
        }
        catch (IndexOutOfRangeException)
        {
            return 0;
        }

        return count;
    }

    /// <summary>
    /// Exercise 4.3 
    /// Find the maximum number in a list.
    /// </summary>
    /// <param name="arr"></param>
    /// <returns>Maximum number in a list</returns>
    public static int GetMaxNumberRecursive(int[] arr, int index = 0)
    {
        int maxNumber = 0;
        if (index == CountRecursive(arr))
        {
            return maxNumber;
        }

        maxNumber = arr[index];
        int nextNumber = GetMaxNumberRecursive(arr, index + 1);

        if (maxNumber < nextNumber)
        {
            maxNumber = nextNumber;
        }

        return maxNumber;
    }
}
