namespace SolutionTest._0106;

using Solutions._0106ConstructBinaryTreeFromInorderAndPostorderTraversal;

[TestClass]
public class SolutionTest
{
    [TestMethod]
    public void Test()
    {
        int[] inorder = { 9, 3, 15, 20, 7 };
        int[] postorder = { 9, 15, 7, 20, 3 };
        var sol = new Solution();
        var root = sol.BuildTree(inorder, postorder);
    }
}