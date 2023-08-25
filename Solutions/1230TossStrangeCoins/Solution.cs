namespace Solutions._1230TossStrangeCoins;

public class Solution
{
    public double ProbabilityOfHeads(double[] prob, int target)
    {
        int n = prob.Length;
        double[,] dp = new double[n + 1, target + 1];
        // base case
        dp[0, 0] = 1; //got 0 coin get 0 head
        for (int i = 1; i < dp.GetLength(0); i++) // get 0 head
        {
            double p = prob[i - 1]; // cause we start from 1
            dp[i, 0] = dp[i - 1, 0] * (1 - p);
        }


        for (int i = 1; i < dp.GetLength(0); i++) // row
        {
            for (int j = 1; j < dp.GetLength(1); j++) // col
            {
                double p = prob[i - 1]; // here we start from 1(first coin)
                dp[i, j] = dp[i - 1, j] * (1 - p) + dp[i - 1, j - 1] * p;
            }
        }

        return dp[n, target];
    }
}