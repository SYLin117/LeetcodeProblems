using MyDataStructure;

namespace Solutions._0094BinaryTreeInorderTraversal;

public class Solution
{
    private IList<int> result;

    public IList<int> InorderTraversal(TreeNode root)
    {
        result = new List<int>();
        Traversal(root);
        return result;
    }

    private void Traversal(TreeNode node)
    {
        if (node == null) return;
        Traversal(node.left);
        result.Add(node.val);
        Traversal(node.right);
    }
}