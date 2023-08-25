namespace SolutionTest._0334;

using Solutions._0334IncreasingTripletSubsequence;

[TestClass]
public class SolutionTest
{
    [TestMethod]
    public void Test()
    {
        var sol = new Solution();
        Assert.AreEqual(false, sol.IncreasingTriplet(new int[] { 1, 1, -2, 6 }));
    }
}