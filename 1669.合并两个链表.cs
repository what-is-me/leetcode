/*
 * @lc app=leetcode.cn id=1669 lang=csharp
 * @lcpr version=21301
 *
 * [1669] 合并两个链表
 */

// @lc code=start
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode MergeInBetween(ListNode list1, int a, int b, ListNode list2) {
        ListNode ret = list1;
        for (int i = 0; i < a - 1; i++) {
            list1 = list1.next;
        }
        ListNode A = list1.next;
        list1.next = list2;
        for (int i = a; i <= b; i++) {
            A = A.next;
        }
        while (list2.next != null) list2 = list2.next;
        list2.next = A;
        return ret;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [0,1,2,3,4,5]\n3\n4\n[1000000,1000001,1000002]\n
// @lcpr case=end

// @lcpr case=start
// [0,1,2,3,4,5,6]\n2\n5\n[1000000,1000001,1000002,1000003,1000004]\n
// @lcpr case=end

 */


