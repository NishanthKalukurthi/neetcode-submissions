public class Solution {
    public int Trap(int[] height) {
        int len=height.Length;
        int[] leftMax=new int[height.Length];
         int[] rightMax=new int[height.Length];
         leftMax[0]=height[0];
         rightMax[len-1]=height[len-1];
         for(int i=1;i<len;i++){
            leftMax[i]=Math.Max(height[i],leftMax[i-1]);
         }
         for(int i=len-2;i>=0;i--){
            rightMax[i]=Math.Max(height[i],rightMax[i+1]);
         }
         int totalTrappedWater=0;
         for(int i=1;i<len-1;i++){
            int maxHeight=Math.Min(leftMax[i],rightMax[i]);
            totalTrappedWater+=(maxHeight-height[i]);
         }
         return totalTrappedWater;
    }
}
