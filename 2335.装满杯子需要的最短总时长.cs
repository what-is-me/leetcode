using System;
/*
 * @lc app=leetcode.cn id=2335 lang=csharp
 * @lcpr version=21504
 *
 * [2335] 装满杯子需要的最短总时长
 */

// @lc code=start
public class Solution {
    public int FillCups(int[] amount) {
        Array.Sort(amount);
        if (amount[2] >= amount[0] + amount[1]) return amount[2];
        return (amount[0] + amount[1] + amount[2] + 1) / 2;
    }
}
// @lc code=end

// @lcpr-div-debug-arg-start
// funName=
// paramTypes= []
// returnType=
// @lcpr-div-debug-arg-end


/*
// @lcpr case=start
// [1,4,2]\n
// @lcpr case=end

// @lcpr case=start
// [5,4,4]\n
// @lcpr case=end

// @lcpr case=start
// [5,0,0]\n
// @lcpr case=end

 */


