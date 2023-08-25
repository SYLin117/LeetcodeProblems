using MyDataStructure;

namespace SolutionTest._1161;
using Solutions._1161MaximumLevelSumOfABinaryTree;
[TestClass]
public class SolutionTest
{
    [TestMethod]
    public void Test()
    {
        var sol = new Solution();
        Assert.AreEqual(2, sol.MaxLevelSum(new int?[] { 1, 7, 0, -7, 8 }.ArrayToTree()));
    }
}