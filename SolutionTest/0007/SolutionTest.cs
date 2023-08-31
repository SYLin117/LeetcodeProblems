namespace SolutionTest._0007;

using Solutions._0007ReverseInteger;

[TestClass]
public class SolutionTest
{
    [TestMethod]
    public void Test()
    {
        var sol = new Solution();
        Assert.AreEqual(321, sol.Reverse(123));
    }
}