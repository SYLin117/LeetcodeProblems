namespace Solutions._0454SumII;

public class Solution
{
    public int FourSumCount(int[] nums1, int[] nums2, int[] nums3, int[] nums4)
    {
        int result = 0;
        Dictionary<int, int> dict = new Dictionary<int, int>();
        foreach (int num1 in nums1)
        {
            foreach (int num2 in nums2)
            {
                if(dict.ContainsKey(num1+num2))
                    dict[num1 + num2] += 1;
                else
                    dict.Add(num1+num2, 1);
            }
        }

        foreach (int num3 in nums3)
        {
            foreach (int num4 in nums4)
            {
                if (dict.ContainsKey(-1 * (num3 + num4)))
                {
                    result += dict[-1 * (num3 + num4)];
                }
            }
        }

        return result;
    }
}