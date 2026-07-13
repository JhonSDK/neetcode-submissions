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
    public bool HasPathSum(TreeNode root, int targetSum) {
        bool dfs(TreeNode node, int currSum){
            if(node == null){
                return false;
            }

            currSum += node.val;
            if(node.left == null && node.right == null){
                return currSum == targetSum;
            }

            return dfs(node.left, currSum) || dfs(node.right, currSum);
        }
        return dfs(root, 0);

    }
}