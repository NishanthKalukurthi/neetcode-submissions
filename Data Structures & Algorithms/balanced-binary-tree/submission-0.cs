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
    public bool IsBalanced(TreeNode root) {
        bool res =true;
        int height=CheckIfBalanced(root , ref res);
        return res;
    }

    public int CheckIfBalanced(TreeNode root , ref bool res){
        if(res==false||root==null) return 0;


        int leftHeight=CheckIfBalanced(root.left , ref res);
        int rightHeight=CheckIfBalanced(root.right , ref res);

        if(Math.Abs(leftHeight-rightHeight)>1) res=false;

        return 1+Math.Max(leftHeight,rightHeight);
    }
}
