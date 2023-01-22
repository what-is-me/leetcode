using Internal;
/*
 * @lc app=leetcode.cn id=1815 lang=csharp
 * @lcpr version=21113
 *
 * [1815] 得到新鲜甜甜圈的最多组数
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
// @lc code=start
public class Solution : Dictionary<long, int> {
    long GetHashCodeOfArray(byte[] statu) {
        long ret=0;
        foreach (byte t in statu) ret = ret << 5 | t;
        return ret;
    }
    int Dfs(byte[] statu, int batchSize) {
        long statu_=GetHashCodeOfArray(statu);
        if (this.ContainsKey(statu_)) return this[statu_];
        int ret=0,sum=0;
        for (int i = 1; i < batchSize; i++) sum += i * statu[i];
        for (int i = 1; i < batchSize; i++) {
            if (statu[i] > 0) {
                statu[i]--;
                ret = Math.Max(ret, Dfs(statu, batchSize) + ((sum - i) % batchSize == 0 ? 1 : 0));
                statu[i]++;
            }
        }
        this.Add(statu_, ret);
        return ret;
    }
    public int MaxHappyGroups(int batchSize, int[] groups) {
        byte[] statu = new byte[batchSize];
        foreach (int group in groups) statu[group % batchSize]++;
        this[((long)statu[0]) << ((batchSize - 1) * 5)] = statu[0];
        return Dfs(statu, batchSize);
    }
}
// @lc code=end



/*
// @lcpr case=start
// 3\n[1,2,3,4,5,6]\n
// @lcpr case=end

// @lcpr case=start
// 4\n[1,3,2,5,2,2,1,6]\n
// @lcpr case=end

 */


