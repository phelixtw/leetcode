/*
 * @lc app=leetcode id=121 lang=csharp
 *
 * [121] Best Time to Buy and Sell Stock
 */

// @lc code=start
using System;
using System.Linq;
using System.Reflection.Emit;


// Input: prices = [7,1,5,3,6,4]
// Output: 5
public class Solution {
    public int MaxProfit(int[] prices) {
        int bestBuy = prices.Max();
        int bestRevenu = 0;
        for(int i=0; i< prices.Length; i++){
            if(prices[i] < bestBuy) {
                bestBuy = prices[i];
            }
            else if(prices[i] - bestBuy > 0){
                bestRevenu = Math.Max(bestRevenu, prices[i] - bestBuy);
            }
        }
        return bestRevenu;
    }
}
// @lc code=end

