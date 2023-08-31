namespace Solutions._0007ReverseInteger;

public class Solution
{
    public int Reverse(int x)
    {
        long result = 0;
        bool isNeg = false;
        if (x < 0)
        {
            isNeg = true;
            x = -1 * x;
        }

        while (x > 0)
        {
            var tmp = x % 10;
            result = result * 10 + tmp;
            x /= 10;
        }

        if (result < Int32.MinValue || result > Int32.MaxValue) return 0;
        return (isNeg) ? (int)result * -1 : (int)result;
    }
}