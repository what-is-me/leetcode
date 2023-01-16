using System.Collections.Generic;
using System.Linq;
/*
 * @lc app=leetcode.cn id=1813 lang=csharp
 * @lcpr version=21110
 *
 * [1813] 句子相似性 III
 */

// @lc code=start
public class Solution
{
    public bool AreSentencesSimilar(string sentence1, string sentence2)
    {
        string[] A = sentence1.Split(" ");
        string[] B = sentence2.Split(" ");
        return IsAIncludeB(A, B) || IsAIncludeB(B, A);
    }
    private bool IsAIncludeB(string[] a, string[] b)
    {
        int n = a.Length, m = b.Length;
        if (n < m) return false;
        if (n == m) return Enumerable.SequenceEqual(a, b);
        int l = 0, r = 0;
        for (; l < m; l++) if (a[l] != b[l]) break;
        for (; r < m; r++) if (a[n - r - 1] != b[m - r - 1]) break;
        return l + r >= m;
    }
}
// @lc code=end



/*
// @lcpr case=start
// "My name is Haley"\n"My Haley"\n
// @lcpr case=end

// @lcpr case=start
// "of"\n"A lot of words"\n
// @lcpr case=end

// @lcpr case=start
// "Eating right now"\n"Eating"\n
// @lcpr case=end

// @lcpr case=start
// "Luky"\n"Lucccky"\n
// @lcpr case=end

 */


