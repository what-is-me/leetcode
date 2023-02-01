/*
 * @lc app=leetcode.cn id=2315 lang=csharp
 * @lcpr version=21301
 *
 * [2315] 统计星号
 */

// @lc code=start
public class Solution {
    public int CountAsterisks(string s) {
        bool flag = false;
        int ret = 0, tmp = 0;
        foreach (char c in s) {
            if (c == '*') {
                ret++;
                if (flag) tmp++;
            } else if (c == '|') {
                if (flag) {
                    ret -= tmp;
                    tmp = 0;
                }
                flag = !flag;
            }
        }
        return ret;
    }
}
// @lc code=end



/*
// @lcpr case=start
// "l|*e*et|c**o|*de|"\n
// @lcpr case=end

// @lcpr case=start
// "iamprogrammer"\n
// @lcpr case=end

// @lcpr case=start
// "yo|uar|e**|b|e***au|tifu|l"\n
// @lcpr case=end

 */


