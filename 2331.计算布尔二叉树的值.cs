/*
 * @lc app=leetcode.cn id=2331 lang=csharp
 * @lcpr version=21501
 *
 * [2331] 计算布尔二叉树的值
 */

// @lc code=start
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
    public bool EvaluateTree(TreeNode root) {
        if (root.val == 0) return false;
        if (root.val == 1) return true;
        if (root.val == 2) return EvaluateTree(root.left) || EvaluateTree(root.right);
        return EvaluateTree(root.left) && EvaluateTree(root.right);
    }
}
// @lc code=end



/*
// @lcpr case=start
// [2,1,3,null,null,0,1]\n
// @lcpr case=end

// @lcpr case=start
// [0]\n
// @lcpr case=end

 */


