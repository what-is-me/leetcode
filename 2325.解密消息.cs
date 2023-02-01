using System;
using System.Text;
/*
 * @lc app=leetcode.cn id=2325 lang=csharp
 * @lcpr version=21401
 *
 * [2325] 解密消息
 */

// @lc code=start
public class Solution {
    public string DecodeMessage(string key, string message) {
        char[] map = new char[26];
        char tmp = 'a';
        foreach (char c in key) {
            if (Char.IsLetter(c)) {
                if (map[c - 'a'] == 0) {
                    map[c - 'a'] = tmp++;
                }
            }
        }
        StringBuilder ret = new StringBuilder();
        foreach (char c in message) {
            if (Char.IsLetter(c)) {
                ret.Append(map[c - 'a']);
            } else {
                ret.Append(c);
            }
        }
        return ret.ToString();
    }
}
// @lc code=end



/*
// @lcpr case=start
// "the quick brown fox jumps over the lazy dog"\n"vkbs bs t suepuv"\n
// @lcpr case=end

// @lcpr case=start
// "eljuxhpwnyrdgtqkviszcfmabo"\n"zwx hnfx lqantp mnoeius ycgk vcnjrdb"\n
// @lcpr case=end

 */


