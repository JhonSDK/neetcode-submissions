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
        if (root != null) {
            queue.Enqueue(root);
        }
        
        while (queue.Count > 0){
            int levelLength = queue.Count;
            List<int> currentLevel = new List<int>();

            for (int i = 0; i < levelLength; i++) {
                TreeNode curr = queue.Dequeue();
                currentLevel.Add(curr.val);
                if (curr.left != null) {
                    queue.Enqueue(curr.left);
                }
                if (curr.right != null) {
                    queue.Enqueue(curr.right);
                }
            }
            result.Add(currentLevel);
        }
        return result;
    }
}
