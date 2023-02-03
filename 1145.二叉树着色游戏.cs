using System;
using System.Globalization;
/*
 * @lc app=leetcode.cn id=1145 lang=csharp
 * @lcpr version=21401
 *
 * [1145] 二叉树着色游戏
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
    TreeNode find(TreeNode root,int x){
        if(root==null)return null;
        if(root.val==x)return root;
        var fdl=find(root.left,x);
        if(fdl==null)return find(root.right,x);
        return fdl;
    }
    Tuple<int,int> Size(TreeNode root){
        if(root==null)return new Tuple<int,int>(0,0);
        int ls=Size(root.left).Item1,rs=Size(root.right).Item1;
        return new Tuple<int,int>(ls+rs+1,Math.Max(ls,rs));
    }
    public bool BtreeGameWinningMove(TreeNode root, int n, int x) {
        TreeNode X=find(root,x);
        var tmp=Size(X);
        int mx=Math.Max(tmp.Item2,n-tmp.Item1);
        return mx*2>n;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [1,2,3,4,5,6,7,8,9,10,11]\n11\n3\n
// @lcpr case=end

// @lcpr case=start
// [1,2,3]\n3\n1\n
// @lcpr case=end

 */


