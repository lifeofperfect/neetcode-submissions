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
    public int KthSmallest(TreeNode root, int k) {

        Stack<TreeNode> stack = new Stack<TreeNode>();
        TreeNode currentNode = root;

        while(currentNode != null || stack.Count > 0){
            while(currentNode != null){
                stack.Push(currentNode);
                currentNode = currentNode.left;
            }

            currentNode = stack.Pop();

            k--;

            if(k==0){
                return currentNode.val;
            }

            currentNode = currentNode.right;
        }

        throw new ArgumentException("Invalid value of k.");
    }
}
