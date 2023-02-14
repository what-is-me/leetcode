/*
 * @lc app=leetcode.cn id=1124 lang=csharp
 * @lcpr version=21505
 *
 * [1124] 表现良好的最长时间段
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
// @lc code=start
public class Solution {
    //理论上暴力能过
    public int LongestWPI(int[] hours) {
        int[] sum = new int[hours.Length + 1];
        for (int i = 0; i < hours.Length; i++) {
            sum[i + 1] = sum[i] + (hours[i] > 8 ? 1 : -1);
        }
        if (sum.Last() > 0) return hours.Length;
        int _base = sum.Min();
        int[] dict = new int[sum.Max() - _base + 3];
        for (int i = 0; i < dict.Length; i++)
            dict[i] = -1;
        int ans = 0;
        for (int i = 0; i < sum.Length; i++) {
            if (dict[sum[i] + 1 - _base] == -1)
                dict[sum[i] + 1 - _base] = i;
            if (dict[sum[i] - _base] != -1) {
                ans = Math.Max(ans, i - dict[sum[i] - _base]);
            }
        }
        return ans;
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
// [9,9,6,0,6,6,9]\n
// @lcpr case=end

// @lcpr case=start
// [6,6,6]\n
// @lcpr case=end

 */


