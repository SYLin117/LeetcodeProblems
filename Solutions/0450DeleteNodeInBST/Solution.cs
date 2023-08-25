using System.Data;
using MyDataStructure;

namespace Solutions._0450DeleteNodeInBST;

public class Solution
{
    /// <summary>
    /// https://www.geeksforgeeks.org/deletion-in-binary-search-tree/
    /// </summary>
    /// <param name="root"></param>
    /// <param name="key"></param>
    /// <returns></returns>
    public TreeNode DeleteNode(TreeNode root, int key)
    {
        // Base case
        if (root == null)
            return root;

        // Recursive calls for ancestors of
        // TreeNode to be deleted
        if (root.val > key)
        {
            root.left = DeleteNode(root.left, key);
            return root;
        }
        else if (root.val < key)
        {
            root.right = DeleteNode(root.right, key);
            return root;
        }

        // We reach here when root is the node
        // to be deleted.
        
        // there would be 3 situation
        // 1. only have one or no child
        if (root.left == null)
        {
            TreeNode temp = root.right;
            return temp;
        }
        else if (root.right == null)
        {
            TreeNode temp = root.left;
            return temp;
        }

        // 2. with 2 children
        else
        {
            TreeNode succParent = root;

            // Find successor
            TreeNode succ = root.right;
            while (succ.left != null)
            {
                succParent = succ;
                succ = succ.left;
            }

            // Delete successor.  Since successor
            // is always left child of its parent (successor should be the left most node in right subtree)
            // we can safely make successor's right 
            // right child as left of its parent.
            // If there is no succ, then assign
            // succ.right to succParent.right
            if (succParent != root)
                succParent.left = succ.right;
            else // sussParent == node should been delete
                succParent.right = succ.right;

            // Copy Successor Data to root
            root.val = succ.val;

            // Delete Successor and return root
            return root;
        }
    }
}