using Microsoft.VisualBasic;

namespace SolutionTest._0088;

using Solutions._0088MergeSortedArray;

[TestClass]
public class SolutionTest
{
    [TestMethod]
    public void Test()
    {
        var sol = new Solution();
        var nums1 = new int[] { 1, 2, 3, 0, 0, 0 };
        var nums2 = new int[] { 2, 5, 6 };
        var result = new int[] { 1, 2, 2, 3, 5, 6 };
        sol.Merge(nums1, 3, nums2, 3);
        CollectionAssert.AreEqual(result, nums1);
    }
}