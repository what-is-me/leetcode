/*
 * @lc app=leetcode.cn id=1237 lang=csharp
 * @lcpr version=21701
 *
 * [1237] 找出给定方程的正整数解
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
// @lc code=start
/*
 * // This is the custom function interface.
 * // You should not implement it, or speculate about its implementation
 * public class CustomFunction {
 *     // Returns f(x, y) for any given positive integers x and y.
 *     // Note that f(x, y) is increasing with respect to both x and y.
 *     // i.e. f(x, y) < f(x + 1, y), f(x, y) < f(x, y + 1)
 *     public int f(int x, int y);
 * };
 */

public class Solution {
    int FindSolution(CustomFunction customfunction, int x, int z) {
        int l = 1, r = 1000;
        while (l <= r) {
            int mid = (l + r) / 2;
            int res = customfunction.f(x, mid);
            if (res == z) {
                return mid;
            } else if (res > z) {
                r = mid - 1;
            } else {
                l = mid + 1;
            }
        }
        return 0;
    }
    public IList<IList<int>> FindSolution(CustomFunction customfunction, int z) {
        List<int[]> ret = new List<int[]>();
        for (int x = 1; x <= 1000; x++) {
            int y = FindSolution(customfunction, x, z);
            if (y != 0) {
                ret.Add(new int[] { x, y });
            }
        }
        return ret.ToArray();
    }
}
// @lc code=end

// @lcpr-div-debug-arg-start
// funName=
// paramTypes=[]
// returnType=
// @lcpr-div-debug-arg-end


/*
// @lcpr case=start
// 1\n5\n
// @lcpr case=end

// @lcpr case=start
// 2\n5\n
// @lcpr case=end

 */


