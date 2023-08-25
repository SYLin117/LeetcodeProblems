namespace Solutions._0054SpiralMatrix;

public class Solution
{
    public IList<int> SpiralOrder(int[][] matrix)
    {
        List<int> result = new();
        int rowBegin = 0;
        int rowEnd = matrix.Length - 1;
        int colBegin = 0;
        int colEnd = matrix[0].Length - 1;

        while (rowBegin <= rowEnd && colBegin <= colEnd)
        {
            for (int i = colBegin; i <= colEnd; i++) // travel right
            {
                result.Add(matrix[rowBegin][i]);
            }

            rowBegin++;
            for (int j = rowBegin; j <= rowEnd; j++) // travel down
            {
                result.Add(matrix[j][colEnd]);
            }

            colEnd--;

            if (rowBegin <= rowEnd) // avoid duplicate
            {
                for (int i = colEnd; i >= colBegin; i--) // travel left
                {
                    result.Add(matrix[rowEnd][i]);
                }
            }

            rowEnd--;

            if (colBegin <= colEnd) // avoid duplicate
            {
                for (int j = rowEnd; j >= rowBegin; j--) // travel up
                {
                    result.Add(matrix[j][colBegin]);
                }
            }

            colBegin++;
        }

        return result;
    }

    public static void Main()
    {
        var sol = new Solution();
        int[][] test = new int[3][];
        test[0] = new int[] { 1, 2, 3 };
        test[1] = new int[] { 4, 5, 6 };
        test[2] = new int[] { 7, 8, 9 };
        foreach (int num in sol.SpiralOrder(test))
        {
            Console.Write($"{num} ");
        }
        
    }
}