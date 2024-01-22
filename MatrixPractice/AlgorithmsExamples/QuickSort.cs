namespace Grokking_Algorithms.MatrixPractice.AlgorithmsExamples
{
    class QuickSort
    {
        public static void Sort<T>(T[] array) where T : IComparable<T>
        {
            if (array == null || array.Length <= 1)
                return;

            QuickSortRecursive(array, 0, array.Length - 1);
        }

        private static void QuickSortRecursive<T>(T[] array, int low, int high) where T : IComparable<T>
        {
            if (low < high)
            {
                // Выбор опорного элемента и получение индекса его окончательного расположения
                int partitionIndex = Partition(array, low, high);

                // Рекурсивная сортировка левой и правой частей
                QuickSortRecursive(array, low, partitionIndex - 1);
                QuickSortRecursive(array, partitionIndex + 1, high);
            }
        }

        private static int Partition<T>(T[] array, int low, int high) where T : IComparable<T>
        {
            // Выбор опорного элемента (в данном случае, последнего элемента в массиве)
            T pivot = array[high];

            // Индекс, с которого начнется разделение элементов
            int i = low - 1;

            // Проход по массиву
            for (int j = low; j < high; j++)
            {
                // Если текущий элемент меньше или равен опорному
                if (array[j].CompareTo(pivot) <= 0)
                {
                    // Увеличение индекса разделения и обмен текущего элемента с элементом, стоящим на позиции i
                    i++;
                    Swap(array, i, j);
                }
            }

            // Обмен опорного элемента с элементом, стоящим сразу за последним меньшим элементом
            Swap(array, i + 1, high);

            // Возвращение индекса, где теперь находится опорный элемент
            return i + 1;
        }

        private static void Swap<T>(T[] array, int i, int j)
        {
            // Вспомогательный метод для обмена значениями местами в массиве
            T temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}
