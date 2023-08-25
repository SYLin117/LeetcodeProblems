namespace SolutionTest._0518;

using Solutions._0518CoinChangeII;

[TestClass]
public class SolutionTest
{
    [TestMethod]
    public void Test()
    {
        var sol = new Solution();
        Assert.AreEqual(4, sol.Change(5, new[] { 1, 2, 5 }));
    }
}