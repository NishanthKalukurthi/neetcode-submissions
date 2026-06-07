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

    public int DiameterOfBinaryTree(TreeNode root) {
        int[] res=new int[1];
        int ves=FindDia(root,res);
        return res[0];
    }

    public int FindDia(TreeNode root, int[] res){
        if(root==null) return 0;

        int maxLeft=FindDia(root.left,res);
        int maxRight=FindDia(root.right,res);
        res[0]=Math.Max(res[0],maxLeft+maxRight);

        return 1+Math.Max(maxLeft,maxRight);
    }
}
