namespace Grokking_Algorithms.MatrixPractice.AlgorithmsExamples;

public class MergeSort
{
    public static void Sort(int[] arr)
    {
        if (arr.Length <= 1)
            return;

        int middle = arr.Length / 2;
        int[] left = new int[middle];
        int[] right = new int[arr.Length - middle];

        for (int i = 0; i < middle; i++)
        {
            left[i] = arr[i];
        }

        for (int i = middle; i < arr.Length; i++)
        {
            right[i - middle] = arr[i];
        }

        Sort(left);
        Sort(right);
        Merge(arr, left, right);
    }

    private static void Merge(int[] arr, int[] left, int[] right)
    {
        int i = 0, j = 0, k = 0;

        while (i < left.Length && j < right.Length)
        {
            if (left[i] <= right[j])
            {
                arr[k] = left[i];
                i++;
            }
            else
            {
                arr[k] = right[j];
                j++;
            }
            k++;
        }

        while (i < left.Length)
        {
            arr[k] = left[i];
            i++;
            k++;
        }

        while (j < right.Length)
        {
            arr[k] = right[j];
            j++;
            k++;
        }
    }
}