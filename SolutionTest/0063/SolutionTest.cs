namespace SolutionTest._0063;

using Solutions._0063UniquePathII;

[TestClass]
public class SolutionTest
{
    [TestMethod]
    public void Test()
    {
        var sol = new Solution();
        int[][] test = new int[3][];
        test[0] = new[] { 0, 0, 0 };
        test[1] = new[] { 0, 1, 0 };
        test[2] = new[] { 0, 0, 0 };
        Assert.AreEqual(2, sol.UniquePathsWithObstacles(test));
    }
}