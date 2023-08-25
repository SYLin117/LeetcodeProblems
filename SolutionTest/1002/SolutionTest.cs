using Solutions._1002FindCommonCharacters;
using Utils;

namespace SolutionTest._1002;

[TestClass]
public class SolutionTest
{
    [TestMethod]
    public void Test()
    {
        var sol = new Solution();
        var result = sol.CommonChars(new string[] { "bella", "label", "roller" });
        result.PrintAllElement();
    }
}