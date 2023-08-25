namespace SolutionTest._0452;

using Solutions._0452MinimumNumberofArrowstoBurstBalloons;

[TestClass]
public class SolutionTest
{
    [TestMethod]
    public void Test()
    {
        var solution = new Solution();
        // [[-2147483646,-2147483645],[2147483646,2147483647]]
        int[][] test = new int[2][];
        test[0] = new[] { 2147483646, -2147483645 };
        test[1] = new[] { 2147483646, 2147483647 };
        solution.FindMinArrowShots(test);
    }
}