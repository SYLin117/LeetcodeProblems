namespace Solutions._1150CheckIfANumberIsMajorityElementInASortedArray;

public class Solution
{
    public bool IsMajorityElement(int[] nums, int target)
    {
        int left = 0;
        int right = 0;
        bool result = false;
        while (left < nums.Length && right < nums.Length)
        {
            if (nums[left] != target)
            {
                left++;
                right++;
            }
            else
            {
                if (nums[left] == nums[right])
                {
                    right++;
                }
                else
                {
                    break;
                }
            }
        }

        if ((right - left) > nums.Length / 2) result = true;

        return result;
    }
}