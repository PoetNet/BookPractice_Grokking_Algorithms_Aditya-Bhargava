namespace Grokking_Algorithms.MatrixPractice.Helpers;

public class ArrayGenerator
{
    public static int[] GetRandomIntArray(int arrayLength, int min = 0, int max = 100)
    {
        int[] arr = new int[arrayLength];
        Random random = new();

        for (int i = 0; i < arrayLength; i++)
        {
            arr[i] = random.Next(min, max);
        }

        return arr;
    }
}