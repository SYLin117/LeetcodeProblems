namespace SolutionTest._0239;

using Solutions._0239SlidingWindowMaximum;

[TestClass]
public class SolutionTest
{
    [TestMethod]
    public void Test()
    {
        var sol = new Solution();
        CollectionAssert.AreEqual(new int[] { 3, 3, -1, 3, 6, 7 },
            sol.MaxSlidingWindow(new int[] { 1, 3, -3, -1, -3, 3, 6, 7 }, 3));
    }
}