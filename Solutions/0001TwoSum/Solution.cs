namespace Solutions._0001TwoSum;

public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        int[] result = new int[2];
        Dictionary<int, int> dict = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            var num = nums[i];
            if (dict.ContainsKey(target - num))
            {
                result[0] = i;
                result[1] = dict[target - num];
                return result;
            }
            else
            {
                dict.TryAdd(num, i);
            }
        }

        return result;
    }
}