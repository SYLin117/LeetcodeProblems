namespace SolutionTest._0003;
using Solutions._0003LengthOfLongestSubstring;
[TestClass]
public class SolutionTest
{
    [TestMethod]
    public void Test()
    {
        var sol = new Solution();
        Assert.AreEqual(1, sol.LengthOfLongestSubstring("bbbbbb"));
    }
}