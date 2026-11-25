/*
 * @lc app=leetcode id=125 lang=csharp
 *
 * [125] Valid Palindrome
 */

// @lc code=start
public class Solution {
    // amanaplanacanalpanama
    public bool IsPalindrome(string s) {
        //s = ".,";
        int i = 0;
        int j = s.Length - 1; //尾
        bool result = true;
        while(i < j){
            while(!char.IsLetterOrDigit(s[i])){
                if(i >= s.Length-1) break;
                i++;
            }

            while(!char.IsLetterOrDigit(s[j])){
                if(j == 0) break;
                j--;
            }

            if(i < j && char.ToLower(s[i]) != char.ToLower(s[j])) {
                result = false;
                break;
            }
            i++;
            j--;    
        }
        
        return result;
        
    }
}
// @lc code=end

