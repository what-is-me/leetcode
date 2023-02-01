using System;
/*
 * @lc app=leetcode.cn id=2303 lang=csharp
 * @lcpr version=21115
 *
 * [2303] 计算应缴税款总额
 */

// @lc code=start
public class Solution {
    public double CalculateTax(int[][] brackets, int income) {
        int ans = 0, last = 0;
        foreach (var item in brackets) {
            if (item[0] < income) {
                ans += (item[0] - last) * item[1];
                last = item[0];
            } else {
                ans += (income - last) * item[1];
                break;
            }
        }
        return ans / 100.0;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [[3,50],[7,10],[12,25]]\n10\n
// @lcpr case=end

// @lcpr case=start
// [[1,0],[4,25],[5,50]]\n2\n
// @lcpr case=end

// @lcpr case=start
// [[2,50]]\n0\n
// @lcpr case=end

 */


