namespace SolutionTest._0014;
using Solutions._0014LongestCommonPrefix;
[TestClass]
public class SolutionTest
{
    [TestMethod]
    public void Test()
    {
        var sol = new Solution();
        string[] strs = new[] { "flower", "flow", "flight" };
        Assert.AreEqual("fl", sol.LongestCommonPrefix(strs));
    }
}