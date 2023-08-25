using Solutions._0212ValidAnagram;

namespace SolutionTest._0212;

[TestClass]
public class SolutionTest
{
    [TestMethod]
    public void Test()
    {
        var sol = new Solution();
        Assert.AreEqual(true, sol.IsAnagram("anagram", "nagaram"));
        // Assert.AreEqual(false, sol.IsAnagram("aba", "zyx"));
    }
}