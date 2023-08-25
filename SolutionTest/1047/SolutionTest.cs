namespace SolutionTest._1047;

using Solutions._1047RemoveAllAdjacentDuplicatesInString;

[TestClass]
public class SolutionTest
{
    [TestMethod]
    public void Test()
    {
        var sol = new Solution();
        Assert.AreEqual("ca", sol.RemoveDuplicates("abbaca"));
    }
}