/*
 * @lc app=leetcode.cn id=1664 lang=csharp
 * @lcpr version=21202
 *
 * [1664] 生成平衡数组的方案数
 */

// @lc code=start
public class Solution {
    int[] oddSum, evenSum, nums;
    void InitSum() {
        oddSum = new int[nums.Length];
        evenSum = new int[nums.Length];
        int os=0,es=0;
        for (int i = 0; i < nums.Length; i++) {
            if (i % 2 == 1) os += nums[i];
            else es += nums[i];
            oddSum[i] = os;
            evenSum[i] = es;
        }
    }
    //[0,pos]
    int OddSumBefore(int pos) {
        if (pos == -1) return 0;
        return oddSum[pos];
    }
    int EvenSumBefore(int pos) {
        if (pos == -1) return 0;
        return evenSum[pos];
    }
    //[pos,n)
    int OddSumAfter(int pos) {
        return oddSum[nums.Length - 1] - OddSumBefore(pos - 1);
    }
    int EvenSumAfter(int pos) {
        return evenSum[nums.Length - 1] - EvenSumBefore(pos - 1);
    }
    bool CheckBalance(int deletedPos) {
        return
        OddSumBefore(deletedPos - 1) +
        EvenSumAfter(deletedPos + 1) ==
        EvenSumBefore(deletedPos - 1) +
        OddSumAfter(deletedPos + 1);
    }
    public int WaysToMakeFair(int[] nums) {
        this.nums = nums;
        InitSum();
        int ret=0;
        for (int i = 0; i < nums.Length; i++) {
            if (CheckBalance(i)) ret++;
        }
        return ret;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [2,1,6,4]\n
// @lcpr case=end

// @lcpr case=start
// [1,1,1]\n
// @lcpr case=end

// @lcpr case=start
// [1,2,3]\n
// @lcpr case=end

 */


