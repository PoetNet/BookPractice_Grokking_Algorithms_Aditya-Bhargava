namespace Grokking_Algorithms.MatrixPractice.AlgorithmsExamples;

public class OtherQuickSort
{
    public static List<T> Sort<T>(List<T> array) where T : IComparable
    {
        if (array.Count < 2)
        {
            return array;
        }
        else
        {
            T pivot = array[0];
            List<T> less = new();
            List<T> greater = new();

            for (int i = 1; i < array.Count; i++)
            {
                if (array[i].CompareTo(pivot) <= 0)
                    less.Add(array[i]);
                else
                    greater.Add(array[i]);
            }

            List<T> sortedList = Sort(less);
            sortedList.AddRange(new List<T>() { pivot });
            sortedList.AddRange(Sort(greater));
            return sortedList;
        }
    }
}
