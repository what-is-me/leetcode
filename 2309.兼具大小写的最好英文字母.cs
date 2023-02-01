/*
 * @lc app=leetcode.cn id=2309 lang=csharp
 * @lcpr version=21202
 *
 * [2309] 兼具大小写的最好英文字母
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Internal;
// @lc code=start
public class Solution {
    public string GreatestLetter(string s) {
        SortedDictionary<string, int> dict = new SortedDictionary<string, int>();
        foreach (char c in s) {
            if (Char.IsUpper(c)) {
                dict[c.ToString()] = dict.GetValueOrDefault(c.ToString(), 0) | 1;
            } else {
                dict[c.ToString().ToUpper()] = dict.GetValueOrDefault(c.ToString().ToUpper(), 0) | 2;
            }
        }
        string ans = "";
        foreach (var item in dict) {
            Console.WriteLine(item);
            if (item.Value == 3) {
                ans = item.Key;
            }
        }
        return ans;
    }
}
// @lc code=end



/*
// @lcpr case=start
// "lEeTcOdE"\n
// @lcpr case=end

// @lcpr case=start
// "arRAzFif"\n
// @lcpr case=end

// @lcpr case=start
// "AbCdEfGhIjK"\n
// @lcpr case=end

 */


