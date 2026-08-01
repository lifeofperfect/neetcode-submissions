/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public List<int> InorderTraversal(TreeNode root) {
        List<int> result = new List<int>();
        Stack<TreeNode> stack = new Stack<TreeNode>();

        TreeNode currentNode = root;

        while(currentNode != null || stack.Count > 0){
            while(currentNode != null){
                stack.Push(currentNode);
                currentNode = currentNode.left;
            }

            currentNode = stack.Pop();

            result.Add(currentNode.val);

            currentNode = currentNode.right;
        }

        return result;
        
    }

    public void Traverse(TreeNode node, List<int> result){
        if(node == null){
            return;
        }

        Traverse(node.left, result);
        result.Add(node.val);
        Traverse(node.right, result);
    }
}