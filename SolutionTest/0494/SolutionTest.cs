namespace SolutionTest._0494;

using Solutions._0494TargetSum;

[TestClass]
public class SolutionTest
{
    [TestMethod]
    public void Test()
    {
        var sol = new Solution();
        Assert.AreEqual(5, sol.FindTargetSumWays(new int[] {1,1,1,1,1}, 3));
    }
}