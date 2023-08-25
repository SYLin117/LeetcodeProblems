namespace Solutions.BagProblem;

/// <summary>
/// 01背包問題
/// </summary>
public class KnapsackProblem01
{
    public int Solution(int[] weight, int[] value, int size)
    {
        int n = weight.Length;
        // i表示是否取第i個物品, j表示在j size可裝的最大value, dp[i, j]表示在size j的背包可取0-i物品的最大值
        int[,] dp = new int[n, size + 1];
        // init first col
        for (int i = 0; i < dp.GetLength(0); i++)
        {
            dp[i, 0] = 0;
        }

        // init first row
        for (int i = 1; i < dp.GetLength(1); i++)
        {
            if (i >= weight[0]) dp[0, i] = value[0];
        }

        for (int i = 1; i < dp.GetLength(0); i++)
        {
            for (int j = 1; j < dp.GetLength(1); j++)
            {
                if (j < weight[i])
                {
                    dp[i, j] = dp[i - 1, j];
                    continue;
                }

                // don't pick item i or pick item i
                dp[i, j] = Math.Max(dp[i - 1, j], dp[i - 1, j - weight[i]] + value[i]);
            }
        }

        return dp[n - 1, size];
    }
}