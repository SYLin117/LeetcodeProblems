namespace Solutions._0088MergeSortedArray;

public class Solution
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        int left = m - 1;
        int right = n - 1;
        int idx = m + n - 1;
        while (left >= 0 && right >= 0)
        {
            if (nums2[right] >= nums1[left])
            {
                nums1[idx] = nums2[right];
                right--;
            }
            else
            {
                nums1[idx] = nums1[left];
                left--;
            }

            idx--;
        }

        while (left >= 0)
        {
            nums1[idx] = nums1[left];
            left--;
            idx--;
        }

        while (right >= 0)
        {
            nums1[idx] = nums2[right];
            right--;
            idx--;
        }
    }
}