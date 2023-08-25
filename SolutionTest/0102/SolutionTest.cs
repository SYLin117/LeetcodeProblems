using MyDataStructure;
using Solutions._0102BinaryTreeLevelOrderTraversal;
namespace SolutionTest._0102;

[TestClass]
public class SolutionTest
{
    [TestMethod]
    public void Test()
    {
        int?[] arr = new int?[] { 3, 9, 20, null, null, 15, 7 };
        TreeNode root = arr.ArrayToTree();
        var sol = new Solution();
        var result = sol.LevelOrder(root);
        Console.WriteLine();
    }
}