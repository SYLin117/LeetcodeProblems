using Solutions._0202HappyNumber;

namespace SolutionTest._0202;

[TestClass]
public class TestSolution
{
    [TestMethod]
    public void Test()
    {
        var sol = new Solution();
        Assert.AreEqual(true, sol.IsHappy(1));
    }
}