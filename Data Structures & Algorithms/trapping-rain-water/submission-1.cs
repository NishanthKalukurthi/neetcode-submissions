public class Solution {
    public int Trap(int[] height) {
        int len=height.Length-1;
        int leftMax=0;
        int rightMax=0;
        int l=0,r=len;
        int trappedWater=0;
        while(l<r){
            leftMax=Math.Max(leftMax,height[l]);
            rightMax=Math.Max(rightMax,height[r]);
            int minHeight=Math.Min(leftMax,rightMax);
            if(leftMax<=minHeight){
                trappedWater+=(minHeight-height[l++]);
            }
            else{
                trappedWater+=(minHeight-height[r--]);
            }
        }
        return trappedWater;
    }
}
