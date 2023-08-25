namespace SolutionTest._0215;

using Solutions._0215KthLargestElementInArray;

[TestClass]
public class SolutionTest
{
    [TestMethod]
    public void Test()
    {
        var sol = new Solution();
        Assert.AreEqual(5, sol.FindKthLargest(new int[] { 3, 2, 1, 5, 6, 4 }, 2));
    }
}