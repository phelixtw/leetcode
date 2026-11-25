/*
 * @lc app=leetcode id=412 lang=csharp
 *
 * [412] Fizz Buzz
 */

// @lc code=start
public class Solution {
    public IList<string> FizzBuzz(int n) {
        int i = 1;
        List<string> list = new List<string>();
        while(i <= n){
            list.Add(
                i % 15 == 0 ? "FizzBuzz" : 
                i % 5 == 0 ? "Buzz" :
                i % 3 == 0 ? "Fizz" :
                i.ToString()
            );
            i++;
        }
        return list;
        
    }
}
// @lc code=end

