public class Solution {

    // babad
    
    public string LongestPalindrome(string s) {
        int bestStart = 0, bestLength = 1;

        for (int i = 0; i < s.Length; i++) { // 中心點會是 s[i]
            int j = 1; // 往中心點外面退 j 步
            for (; i - j >= 0 && i + j < s.Length; j++) {
                if (s[i - j] != s[i + j]) break; // 左右字元不一致
                // i = 0, j = 1, i - j < 0,  x
                // i = 1, j = 1, i - j => b , i + j => b, o
                // i = 1, j = 2, i - j < 0 , x
            }
            int length = 2 * (j - 1) + 1; // j會停在失敗的那一步 , 所以會多走一格, j 要減 1, +1 是中心點
            if (length > bestLength) {
                bestStart = i - (j - 1); 
                bestLength = length; 
            }
        }


        // cbbd
        // cvbbvd
        for (int i = 0; i + 1 < s.Length; i++) { // 中心點會是 s[i] 跟 s[i+1]
            if(s[i] != s[i+1]) continue; // i = 1, i+1 = 1, bb
            int j = 1; // 往中心點外面退 j 步
            for (; i - j >= 0 && i + 1 + j < s.Length; j++) {
                if (s[i - j] != s[i + 1 + j]) break; // 左右字元不一致
                // i = 2, j = 1, vv , o
                // i = 2, j = 2, cd , x
            }
            int length = 2 * j; // j 仍會停在失敗那一步, 但不用減一
            if (length > bestLength) {
                bestStart = i - (j - 1); 
                bestLength = length; 
            }
        }

        return s.Substring(bestStart, bestLength);
    }
}