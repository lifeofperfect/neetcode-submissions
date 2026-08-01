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
    public List<List<int>> LevelOrder(TreeNode root) {

        List<List<int>> result = new List<List<int>>();

        Queue<TreeNode> queue = new Queue<TreeNode>();

        if(root == null){
            return result;
        }

        queue.Enqueue(root);

        while(queue.Count > 0){
            int levelSize = queue.Count();
            List<int> eachList = new List<int>();

            for(int i=0; i< levelSize; i++){
                TreeNode currentNode = new TreeNode();

                currentNode = queue.Dequeue();

                eachList.Add(currentNode.val);

                if(currentNode.left != null){
                    queue.Enqueue(currentNode.left);
                }

                if(currentNode.right != null){
                    queue.Enqueue(currentNode.right);
                }
            }

            result.Add(eachList);
        }

        return result;
    }
}
