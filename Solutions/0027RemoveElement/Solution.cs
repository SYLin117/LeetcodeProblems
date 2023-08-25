namespace Solutions._0027RemoveElement;

public class Solution
{
    public int RemoveElement(int[] nums, int val)
    {
        int slow = 0;
        int fast = 0;
        while (fast < nums.Length)
        {
            if (nums[fast] != val)
            {
                nums[slow] = nums[fast];
                slow++;
            }

            fast++;
        }

        return slow;
    }
}