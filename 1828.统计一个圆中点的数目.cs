/*
 * @lc app=leetcode.cn id=1828 lang=csharp
 * @lcpr version=21115
 *
 * [1828] 统计一个圆中点的数目
 */

// @lc code=start
public class Solution {
    int Pow2(int x) { return x * x; }
    int Distance2(int x1, int y1, int x2, int y2) {
        return Pow2(x1 - x2) + Pow2(y1 - y2);
    }
    public int CountPoints(int[] point, int[] circle) {
        return Distance2(point[0], point[1], circle[0], circle[1]) <= Pow2(circle[2]) ? 1 : 0;
    }
    public int CountPoints(int[][] points, int[] circle) {
        int ret = 0;
        foreach (var point in points) {
            ret += CountPoints(point, circle);
        }
        return ret;
    }
    public int[] CountPoints(int[][] points, int[][] circles) {
        int[] ret = new int[circles.Length];
        for (int i = 0; i < circles.Length; i++) {
            ret[i] = CountPoints(points, circles[i]);
        }
        return ret;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [[1,3],[3,3],[5,3],[2,2]]\n[[2,3,1],[4,3,1],[1,1,2]]\n
// @lcpr case=end

// @lcpr case=start
// [[1,1],[2,2],[3,3],[4,4],[5,5]]\n[[1,2,2],[2,2,2],[4,3,2],[4,3,3]]\n
// @lcpr case=end

 */


