namespace SolutionTest._0006;
using Solutions._0006ZigzagConversion;
[TestClass]
public class SolutionTest
{
    [TestMethod]
    public void Test()
    {
        var sol = new Solution();
        Assert.AreEqual("PAHNAPLSIIGYIR", sol.Convert("PAYPALISHIRING", 3));
    }
}