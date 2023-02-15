/*
 * @lc app=leetcode.cn id=1250 lang=csharp
 * @lcpr version=21601
 *
 * [1250] 检查「好数组」
 */

// @lc code=start
// gcd(a,b)==1则ax+by=1有解
public class Solution {
    int gcd(int a, int b) {
        return a == 0 ? b : b == 0 ? a : gcd(b, a % b);
    }
    public bool IsGoodArray(int[] nums) {
        int g = 0;
        foreach (int num in nums) {
            g = gcd(g, num);
            if (g == 1) return true;
        }
        return g == 1;
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
// [12,5,7,23]\n
// @lcpr case=end

// @lcpr case=start
// [29,6,10]\n
// @lcpr case=end

// @lcpr case=start
// [3,6]\n
// @lcpr case=end

 */


