namespace SolutionTest._0443;
using Solutions._0443Compress;
[TestClass]
public class SolutionTest
{
    [TestMethod]
    public void Test()
    {
        var sol = new Solution();
        Assert.AreEqual(4, sol.Compress(new char[]{'a','b','b','b','b','b','b','b','b','b','b','b','b'}));
    }
}