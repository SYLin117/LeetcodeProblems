namespace SolutionTest._2390;
using Solutions._2390RmovingStarsFromAString;
[TestClass]
public class SolutionTest
{
    [TestMethod]
    public void Test()
    {
        var sol = new Solution();
        string test = "leet**cod*e";
        Assert.AreEqual("lecoe", sol.RemoveStars(test));
    }
}