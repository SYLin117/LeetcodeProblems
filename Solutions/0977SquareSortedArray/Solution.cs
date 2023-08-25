namespace Solutions._0977SquareSortedArray;

public class Solution
{
    public int[] SortedSquares(int[] nums)
    {
        int left = 0;
        int right = nums.Length - 1;
        int[] result = new int[nums.Length];
        int idx = nums.Length - 1;
        while (left <= right)
        {
            if (Math.Abs(nums[left]) >= Math.Abs(nums[right]))
            {
                result[idx] = nums[left] * nums[left];
                left++;
            }
            else if (Math.Abs(nums[left]) < Math.Abs(nums[right]))
            {
                result[idx] = nums[right] * nums[right];
                right--;
            }

            idx--;
        }

        return result;
    }
}