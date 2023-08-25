namespace SolutionTest._0605;

using Solutions._0605CanPlaceFlowers;

[TestClass]
public class SolutionTest
{
    [TestMethod]
    public void Test()
    {
        var sol = new Solution();
        Assert.AreEqual(false, sol.CanPlaceFlowers(new int[] { 1, 0, 1, 0, 1, 0, 1 }, 1));
    }
}