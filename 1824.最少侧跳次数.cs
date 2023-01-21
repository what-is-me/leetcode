using System;
/*
 * @lc app=leetcode.cn id=1824 lang=csharp
 * @lcpr version=21113
 *
 * [1824] 最少侧跳次数
 */

// @lc code=start
public class Solution {
    static void Swap<T>(ref T lhs, ref T rhs) {
        T temp;
        temp = lhs;
        lhs = rhs;
        rhs = temp;
    }
    public int MinSideJumps(int[] obstacles) {
        int[] dp=new int[3],last=new int[3]{0x3f3f3f3f,0,0x3f3f3f3f};
        foreach (var t in obstacles) {
            if (t != 0) last[t - 1] = 0x3f3f3f3f;
            last.CopyTo(dp, 0);
            int minJump = Math.Min(Math.Min(last[0], last[1]), last[2]) + 1;
            for (int i = 0; i < 3; i++) {
                dp[i] = Math.Min(minJump, dp[i]);
            }
            if (t != 0) dp[t - 1] = 0x3f3f3f3f;
            Swap(ref dp, ref last);
        }
        return Math.Min(Math.Min(last[0], last[1]), last[2]);
    }
}
// @lc code=end



/*
// @lcpr case=start
// [0,1,2,3,0]\n
// @lcpr case=end

// @lcpr case=start
// [0,1,1,3,3,0]\n
// @lcpr case=end

// @lcpr case=start
// [0,2,1,0,3,0]\n
// @lcpr case=end

 */


