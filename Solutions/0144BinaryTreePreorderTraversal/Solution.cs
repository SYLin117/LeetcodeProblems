using MyDataStructure;

namespace Solutions._0144BinaryTreePreorderTraversal;

public class Solution
{
    public IList<int> result;

    public IList<int> PreorderTraversal(TreeNode root)
    {
        result = new List<int>();
        Traversal(root);
        return result;
    }

    private void Traversal(TreeNode node)
    {
        if (node == null) return;
        result.Add(node.val);
        Traversal(node.left);
        Traversal(node.right);
    }
}