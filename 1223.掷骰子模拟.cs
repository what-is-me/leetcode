/*
 * @lc app=leetcode.cn id=1223 lang=csharp
 * @lcpr version=21504
 *
 * [1223] 掷骰子模拟
 */

// @lc code=start
public class Solution {
    private const int mod = 1000000007;
    private int[,] dp;
    private int[] tmp;
    public Solution() {
        dp = new int[6, 16];
        tmp = new int[6];
        for (int i = 0; i < 6; i++) dp[i, 0] = 1;
    }
    //dp[i][j] 最后一次投到i且连续投出了j次的
    public int DieSimulator(int n, int[] rollMax) {
        int sum = 0;
        for (int step = 0; step < n; step++) {
            sum = 0;
            for (int i = 0; i < 6; i++) {
                tmp[i] = 0;
                for (int j = rollMax[i]; j > 0; j--) {
                    dp[i, j] = dp[i, j - 1];
                    tmp[i] = (tmp[i] + dp[i, j]) % mod;
                    sum = (sum + dp[i, j]) % mod;
                }
            }
            for (int i = 0; i < 6; i++) {
                dp[i, 0] = (sum - tmp[i] + mod) % mod;
            }
        }
        return sum;
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
// 2\n[1,1,2,2,2,3]\n
// @lcpr case=end

// @lcpr case=start
// 2\n[1,1,1,1,1,1]\n
// @lcpr case=end

// @lcpr case=start
// 3\n[1,1,1,2,2,3]\n
// @lcpr case=end

 */


