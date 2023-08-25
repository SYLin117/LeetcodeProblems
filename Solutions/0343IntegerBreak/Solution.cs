namespace Solutions._0343IntegerBreak;

public class Solution
{
    public int IntegerBreak(int n)
    {
        // dp[i] means the maximum product you can get from i
        int[] dp = new int[n + 1];
        dp[2] = 1; // 2 = 1 + 1
        for (int i = 3; i <= n; i++)
        {
            for (int j = 1; j < i / 2; i++)
            {
                dp[i] = Math.Max(dp[i], Math.Max(i * (i - j), i * dp[i - j]));
            }
        }

        return dp[n];
    }
}