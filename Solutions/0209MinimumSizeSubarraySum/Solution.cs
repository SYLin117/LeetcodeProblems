namespace Solutions._0209MinimumSizeSubarraySum;

public class Solution
{
    public int MinSubArrayLen(int target, int[] nums)
    {
        int left = 0;
        int right = 0;
        int sum = nums[left];
        int minResult = Int32.MaxValue;
        while (right < nums.Length)
        {
            if (sum >= target)
            {
                if ((right - left + 1) < minResult)
                    minResult = right - left + 1;

                sum -= nums[left];
                left++;
            }

            if (sum < target)
            {
                right++;
                if (right >= nums.Length)
                    break;
                sum += nums[right];
            }
        }

        if (minResult == Int32.MaxValue)
            return 0;
        else
            return minResult;
    }
}