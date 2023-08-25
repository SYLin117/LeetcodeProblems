namespace Solutions._0349IntersectionofTwoArrays;

public class Solution
{
    public int[] Intersection(int[] nums1, int[] nums2)
    {
        HashSet<int> set1 = new HashSet<int>(nums1);
        HashSet<int> result = new HashSet<int>();
        foreach (int i in nums2)
        {
            if (set1.Contains(i))
            {
                result.Add(i);
            }
        }

        return result.ToArray();
    }
}