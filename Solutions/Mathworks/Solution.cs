namespace Solutions.Mathworks;

public class Solution
{
    public double ValidPassword(int n, int k)
    {
        // dp[i, j] 表示長度i的password且最後一個字重複j次的個數
        int[,] dp = new int[n + 1, k + 1];
        dp[1, 1] = 26;
        for (int i = 2; i < dp.GetLength(0); i++)
        {
            var prevRowSum = 0;
            for (int col = 1; col < dp.GetLength(1); col++)
            {
                prevRowSum += dp[i-1, col];
            }
            dp[i, 1] = prevRowSum * 25; // 只要最後一個字不同

            for (int j = 2; j < k; j++)
            {
                dp[i, j] = dp[i - 1, j - 1];
            }
        }

        int result = 0;
        for (int j = 1; j < k; j++)
        {
            result += dp[n, j];
        }

        return result;
    }
}