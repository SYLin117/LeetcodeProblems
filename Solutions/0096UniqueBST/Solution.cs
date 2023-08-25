namespace Solutions._0096UniqueBST;

public class Solution
{
    public int NumTrees(int n)
    {
        // dp[i] reprecent the count of trees that i nodes could have
        int[] dp = new int[n + 1];
        dp[0] = 1;
        dp[1] = 1;
        dp[2] = 2;
        for (int i = 3; i <= n; i++)
        {
            for (int j = 0; j <= i - 1; j++)
            {
                dp[i] += dp[j] * dp[i - 1 - j];
            }
        }

        return dp[n];
    }
}