using System.Text;
/*
 * @lc app=leetcode.cn id=1663 lang=csharp
 * @lcpr version=21115
 *
 * [1663] 具有给定数值的最小字符串
 */

// @lc code=start
public class Solution {
    public string GetSmallestString(int n, int k) {
        k -= n;
        char[] ret = new char[n];
        for (int i = n - 1; i >= 0; i--) {
            if (k > 25) {
                ret[i] = 'z';
                k -= 25;
            } else {
                ret[i] = (char)('a' + k);
                k = 0;
            }
        }
        return new string(ret);
    }
}
// @lc code=end



/*
// @lcpr case=start
// 3\n27\n
// @lcpr case=end

// @lcpr case=start
// 5\n73\n
// @lcpr case=end

 */


