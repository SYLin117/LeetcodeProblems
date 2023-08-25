using System.Collections;

namespace Solutions._00153Sum;

public class Solution
{
    public IList<IList<int>> ThreeSum(int[] nums)
    {
        IList<IList<int>> result = new List<IList<int>>();
        Array.Sort(nums);

        int left, right;
        int i;
        for (i = 0; i < nums.Length; i++)
        {
            if (nums[i] > 0)
            {
                return result;
            }

            if (i != 0 && nums[i] == nums[i - 1]) continue;
            left = i + 1;
            right = nums.Length - 1;

            while (left < right)
            {
                var sum = nums[i] + nums[left] + nums[right];
                if (sum < 0)
                {
                    left++;
                }
                else if (sum > 0)
                {
                    right--;
                }
                else
                {
                    result.Add(new List<int>() { nums[i], nums[left], nums[right] });
                    while (left < right && nums[left] == nums[left + 1]) left++;
                    while (left < right && nums[right] == nums[right - 1]) right--;
                    left++;
                    right--;
                }
            }
        }

        return result;
    }
}