/*
 * @lc app=leetcode id=4 lang=csharp
 *
 * [4] Median of Two Sorted Arrays
 */

// @lc code=start
public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        nums1 = nums1.Concat(nums2).ToArray();
        Array.Sort(nums1);
        int length = nums1.Length;
        if (length % 2 == 0) {
            return (nums1[length / 2 - 1] + nums1[length / 2]) / 2.0;
        } else {
            return nums1[length / 2];
        }
    }
}
// @lc code=end

