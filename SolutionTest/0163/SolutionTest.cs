namespace SolutionTest._0163;

using Solutions._0163MissingRanges;

[TestClass]
public class SolutionTest
{
    [TestMethod]
    public void Test()
    {
        var sol = new Solution();
        sol.FindMissingRanges(new[] { 0, 1, 3, 50, 75 }, 0, 99);
    }
}