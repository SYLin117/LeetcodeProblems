using Solutions.Mathworks;

namespace SolutionTest.Mathworks;
[TestClass]
public class SolutionTest
{
    [TestMethod]
    public void Test()
    {
        var sol = new Solution();
        Assert.AreEqual(16250, sol.ValidPassword(3, 2));
    }
}