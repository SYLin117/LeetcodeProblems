namespace SolutionTest._0011;

using Solutions._0011ContainerWithMostWater;

[TestClass]
public class SolutionTest
{
    [TestMethod]
    public void Test()
    {
        var sol = new Solution();
        Assert.AreEqual(17, sol.MaxArea(new int[] { 2, 3, 4, 5, 18, 17, 6 }));
    }
}