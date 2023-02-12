/*
 * @lc app=leetcode.cn id=1138 lang=csharp
 * @lcpr version=21505
 *
 * [1138] 字母板上的路径
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
// @lc code=start
public class Solution {
    public string AlphabetBoardPath(string target) {
        StringBuilder stringBuilder = new StringBuilder();
        int x = 0, y = 0;
        foreach (char c in target) {
            int cx = (c - 'a') / 5;
            int cy = (c - 'a') % 5;

            while (y > cy) {
                stringBuilder.Append('L');
                y--;
            }
            while (x > cx) {
                stringBuilder.Append('U');
                x--;
            }
            while (x < cx) {
                stringBuilder.Append('D');
                x++;
            }
            while (y < cy) {
                stringBuilder.Append('R');
                y++;
            }
            stringBuilder.Append('!');
        }
        return stringBuilder.ToString();
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
// "leet"\n
// @lcpr case=end

// @lcpr case=start
// "code"\n
// @lcpr case=end

 */


