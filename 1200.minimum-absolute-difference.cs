/*
 * @lc app=leetcode id=1200 lang=csharp
 *
 * [1200] Minimum Absolute Difference
 */

// @lc code=start
public class Solution {
    public IList<IList<int>> MinimumAbsDifference(int[] arr) {
        arr.Sort();
        IList<IList<int>> ans = new List<IList<int>>();
        int distance = arr.Min() - arr.Max();
        int i = 0;
        while(i < arr.Length && i+1 < arr.Length){
            if(arr[i] - arr[i+1] > distance){
                distance = arr[i] - arr[i+1];
                ans = new List<IList<int>>();
            }else if(arr[i] - arr[i+1] < distance){
                i++;
                continue;
            }
            ans.Add(new List<int>{arr[i], arr[i+1]});
            i++;
        }
        return ans;

    }
}
// @lc code=end

