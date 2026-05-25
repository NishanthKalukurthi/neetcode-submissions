public class Solution {
    public int MaxArea(int[] heights) {
        int maxarea=0;
        int start=0;int end=heights.Length-1;
        while(start<end){
            int curMinHeight=Math.Min(heights[start],heights[end]);
            int containerVolume=curMinHeight*(end-start);
            maxarea=Math.Max(maxarea,containerVolume);
            if(heights[start]>curMinHeight){
                end--;
            }
            else{
                start++;
            }
        }
        return maxarea;
    }
}
