namespace SolutionTest._0394;
using Solutions._0394DecodeString;
[TestClass]
public class SolutionTest
{
    [TestMethod]
    public void Test()
    {
        var sol = new Solution();
        Assert.AreEqual("abcabccdcdcdef", sol.DecodeString("2[abc]3[cd]ef"));
    }
}