public class Solution {
    public int LargestRectangleArea(int[] heights) {
        int maxArea=0;

        for(int i=0;i<heights.Length;i++){
            int minHeight=heights[i];
            for(int j=i;j<heights.Length;j++){
                minHeight=Math.Min(minHeight,heights[j]);
                maxArea=Math.Max(maxArea,(minHeight*(j-i+1)));
            }
        }
        return maxArea;
    }
}
