namespace SolutionTest._0345;
using Solutions._0345ReverseVowelsOfAString;
[TestClass]
public class SolutionTest
{
    [TestMethod]
    public void Test()
    {
        var sol = new Solution();
        Assert.AreEqual(".,", sol.ReverseVowels(".,"));
    }
}