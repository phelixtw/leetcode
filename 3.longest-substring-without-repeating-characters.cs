/*
 * @lc app=leetcode id=3 lang=csharp
 *
 * [3] Longest Substring Without Repeating Characters
 */

// @lc code=start
public class Solution {

    // abcabcbb
    public int LengthOfLongestSubstring(string s) {
        int inputLenght = s.Length; // 8
        int result = 0; 

        for (int i = 0; i < inputLenght; i++) { // i作為起點
            var set = new HashSet<char>();
            for (int j = i; j < inputLenght; j++) {
                if (set.Contains(s[j])) // set用來檢查重複
                    break; // j 作為終點 
                set.Add(s[j]);
                result = Math.Max(result, j - i + 1); // 取大
            }
        }
        return result;
    }
}
// @lc code=end

