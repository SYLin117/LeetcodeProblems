namespace Solutions._0031NextPermutation;

public class Solution
{
    public void NextPermutation(int[] nums)
    {
        // find the first value not follow monotonically decreasing
        // eg. 23752 -> 3
        int pivot = nums.Length - 2;
        while (pivot >= 0 && !(nums[pivot] < nums[pivot + 1]))
        {
            pivot--;
        }

        if (pivot < 0)
        {
            Array.Sort(nums);
            Console.WriteLine(nums);
            return;
        }

        // find the most right bit that bigger than nums[i]
        int j = nums.Length - 1;
        while (nums[pivot] >= nums[j])
        {
            j--;
        }

        Swap(nums, pivot, j);

        // make right part monotonically increase, cause whole number is 
        // already bigger than original, so we want right part as small as possible
        Reverse(nums, pivot + 1, nums.Length - 1); // cuz it's monotonically decreasing
    }

    public void Swap(int[] nums, int left, int right)
    {
        int tmp = nums[left];
        nums[left] = nums[right];
        nums[right] = tmp;
    }

    public void Reverse(int[] nums, int left, int right)
    {
        while (left < right)
        {
            Swap(nums, left, right);
            left++;
            right--;
        }
    }
}