/*
 * @lc app=leetcode.cn id=1798 lang=csharp
 * @lcpr version=21401
 *
 * [1798] 你能构造出连续值的最大数目
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
// @lc code=start
public class Solution {
    public int GetMaximumConsecutive(int[] coins) {
        List<int> coins_ = new List<int>(coins);
        coins_.Sort();
        int ret = 1;
        foreach (int coin in coins_) {
            if (ret < coin) return ret;
            ret = coin + ret;
        }
        return ret;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [1,3]\n
// @lcpr case=end

// @lcpr case=start
// [1,1,1,4]\n
// @lcpr case=end

// @lcpr case=start
// [1,4,10,3,1]\n
// @lcpr case=end

 */


