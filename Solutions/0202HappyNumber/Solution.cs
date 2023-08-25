namespace Solutions._0202HappyNumber;

public class Solution
{
    public bool IsHappy(int n)
    {
        HashSet<int> set = new HashSet<int>();
        while (n >= 1)
        {
            var sum = 0;
            while (n > 0)
            {
                var tmp = n % 10;
                sum += tmp * tmp;
                n /= 10;
            }

            if (sum == 1)
            {
                return true;
            }
            else
            {
                if (set.Contains(sum))
                {
                    return false;
                }
                else
                {
                    set.Add(sum);
                }

                n = sum;
            }
        }

        return false;
    }
}