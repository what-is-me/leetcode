using Internal;
using System;
using System.Collections.Generic;
/*
 * @lc app=leetcode.cn id=1814 lang=csharp
 * @lcpr version=21110
 *
 * [1814] 统计一个数组中好对子的数目
 */

// @lc code=start
public class Solution {
    const int MOD=1000000007;
    private int rev(int x) {
        int ret=0;
        while (x != 0) {
            ret = ret * 10 + x % 10;
            x /= 10;
        }
        return ret;
    }
    public int CountNicePairs(int[] nums) {
        Dictionary<int,int> map=new Dictionary<int, int>();
        foreach (int num in nums) {
            int tmp=num - rev(num);
            map[tmp] = map.GetValueOrDefault(tmp, 0) + 1;
        }
        long ret=0;
        foreach (var item in map) {
            ret = (ret + 1L * item.Value * (item.Value - 1) / 2) % MOD;
        }
        return Convert.ToInt32(ret);
    }
}
// @lc code=end



/*
// @lcpr case=start
// [42,11,1,97]\n
// @lcpr case=end

// @lcpr case=start
// [13,10,35,24,76]\n
// @lcpr case=end

 */


