namespace Grokking_Algorithms.Algorithms;
public static class StringSequenceCalculator
{
    public static int CalculateSequence(string wordA, string wordB)
    {
        int[,] cell = new int[wordA.Length + 1, wordB.Length + 1];

        for (int i = 1; i <= wordA.Length; i++)
        {
            for (int j = 1; j <= wordA.Length; j++)
            {
                if (wordA[i - 1] == wordB[j - 1])
                {
                    cell[i,j] = cell[i - 1, j - 1] + 1;
                }
                else
                {
                    cell[i, j] = Math.Max(cell[i, j - 1], cell[i - 1, j]);
                }
            }
        }

        return cell[wordA.Length, wordB.Length];
    }
}
