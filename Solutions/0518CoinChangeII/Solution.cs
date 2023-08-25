namespace Solutions._0518CoinChangeII;

public class Solution
{
    public int Change(int amount, int[] coins)
    {
        int[] dp = new int[amount + 1];
        dp[0] = 1;
        for (int j = 0; j <= amount; j++) // bag
        {
            for (int i = 0; i < coins.Length; i++) // item
            {
                if (j - coins[i] >= 0) dp[j] += dp[j - coins[i]];
            }
        }

        return dp[amount];
    }
}