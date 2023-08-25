using MyDataStructure;

namespace SolutionTest._0112;

using Solutions._0112PathSum;

[TestClass]
public class SolutionTest
{
    [TestMethod]
    public void Test()
    {
        // int?[] nums = { 5, 4, 8, 11, null, 13, 4, 7, 2, null, null, null, 1 };
        int?[] nums2 = { 1, 2 };
        var sol = new Solution();
        var head = nums2.ArrayToTree();
        Assert.AreEqual(false, sol.HasPathSum(head, 1));
    }
}