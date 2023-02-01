using System.Collections.Generic;
/*
 * @lc app=leetcode.cn id=1817 lang=csharp
 * @lcpr version=21113
 *
 * [1817] 查找用户活跃分钟数
 */

// @lc code=start
public class Solution {
    public int[] FindingUsersActiveMinutes(int[][] logs, int k) {
        Dictionary<int, SortedSet<int>> map = new Dictionary<int, SortedSet<int>>();
        foreach (var log in logs) {
            int p = log[0], t = log[1];
            if (!map.ContainsKey(p)) map[p] = new SortedSet<int>();
            map[p].Add(t);
        }
        int[] ret = new int[k];
        foreach (var item in map) {
            ret[item.Value.Count - 1] += 1;
        }
        return ret;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [[0,5],[1,2],[0,2],[0,5],[1,3]]\n5\n
// @lcpr case=end

// @lcpr case=start
// [[1,1],[2,2],[2,3]]\n4\n
// @lcpr case=end

 */


