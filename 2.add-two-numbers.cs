/*
 * @lc app=leetcode id=2 lang=csharp
 *
 * [2] Add Two Numbers
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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        var result = new ListNode(); // 起始開始會是 0, 
        ListNode current = result; //指向result的當前節點
        int carry = 0; 
        while (l1 != null || l2 != null || carry > 0) {
            int sum = carry;
            if (l1 != null) {
                sum += l1.val;
                l1 = l1.next;
            }
            if (l2 != null) {
                sum += l2.val;
                l2 = l2.next;
            }
            carry = sum / 10; //滿十進位 先記著
            current.next = new ListNode(sum % 10); // 第一輪在 0 , (這邊寫上7)
            current = current.next; // 把 current 指向 7 這個節點 
        }
        return result.next; // 因為 result 的第一個節點是 0, 所以要回傳 result.next
    }
}
// @lc code=end

