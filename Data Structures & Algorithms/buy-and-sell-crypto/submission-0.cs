public class Solution {
    public int MaxProfit(int[] prices) {
        int rightMax=prices[prices.Length-1];
        int maxProfit=0;
        for(int i=prices.Length-2;i>=0;i--){
            rightMax=Math.Max(rightMax,prices[i]);
            maxProfit=Math.Max(maxProfit,rightMax-prices[i]);
        }
        return maxProfit;
    }
}
