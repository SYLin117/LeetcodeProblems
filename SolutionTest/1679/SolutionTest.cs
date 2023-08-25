namespace SolutionTest._1679;

using Solutions._1679MaxNumberofKSumPairs;
[TestClass]
public class SolutionTest
{
    [TestMethod]
    public void Test()
    {
        var sol = new Solution();
        Assert.AreEqual(2, sol.MaxOperations(new int[] {1,2,3,4}, 5));
    }
}