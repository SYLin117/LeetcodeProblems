using MyDataStructure;

namespace SolutionTest._1448;
using Solutions._1448CountGoodNodesInBinaryTree;
[TestClass]
public class SolutionTest
{
    [TestMethod]
    public void Test()
    {
        var test = new int?[] { 3, 1, 4, 3, null, 1, 5 }.ArrayToTree();
        var sol = new Solution();
        Assert.AreEqual(4, sol.GoodNodes(test));
    }
}