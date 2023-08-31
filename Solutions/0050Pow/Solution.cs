namespace Solutions._0050Pow;

public class Solution
{
    public static double MyPow(double x, int n)
    {
        if (n < 0) return 1 / x * MyPow(1 / x, -(n + 1));
        if (n == 0) return 1;
        if (n == 1) return x;
        if (n == 2) return x * x;
        if (n % 2 == 0)
        {
            return MyPow(MyPow(x, n / 2), 2);
        }
        else
        {
            return x * MyPow(MyPow(x, n / 2), 2);
        }
    }

    public static void Main()
    {
        Console.WriteLine(MyPow(2, 9));
    }
}