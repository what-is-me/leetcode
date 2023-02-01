using System;
using System.Collections.Generic;
/*
 * @lc app=leetcode.cn id=2299 lang=csharp
 * @lcpr version=21111
 *
 * [2299] 强密码检验器 II
 */

// @lc code=start
public class Solution {
    private static readonly SortedSet<char> specialCharacter = new SortedSet<char>("!@#$%^&*()-+");
    private static int TypeOf(char c) {
        if (Char.IsLower(c)) return 0b1;
        if (Char.IsUpper(c)) return 0b10;
        if (Char.IsDigit(c)) return 0b100;
        if (specialCharacter.Contains(c)) return 0b1000;
        return 0;
    }
    public bool StrongPasswordCheckerII(string password) {
        if (password.Length < 8) return false;
        int chk = 0;
        char last = '\t';
        foreach (char c in password) {
            if (c == last) return false;
            chk |= TypeOf(c);
            last = c;
        }
        return chk == 0b1111;
    }
}
// @lc code=end



/*
// @lcpr case=start
// "IloveLe3tcode!"\n
// @lcpr case=end

// @lcpr case=start
// "Me+You--IsMyDream"\n
// @lcpr case=end

// @lcpr case=start
// "1aB!"\n
// @lcpr case=end

 */


