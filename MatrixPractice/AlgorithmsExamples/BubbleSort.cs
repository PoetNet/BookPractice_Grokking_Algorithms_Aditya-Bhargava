using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grokking_Algorithms.MatrixPractice.AlgorithmsExamples;
public class BubbleSort
{
    public static void Sort<T>(T[] array) where T : IComparable
    {
        int length = array.Length;
        for (var i = 0; i < length; i++)
        {
            for (var j = 0; j < length - i - 1; j++)
            {
                if (array[j].CompareTo(array[j + 1]) > 0 )
                {
                    (array[j], array[j + 1]) = (array[j + 1], array[j]);
                }
            }
        }
    }
}

