public class Solution {
    public int FindMin(int[] nums) {
        int left=0;
        int right=nums.Length-1;
        int min=int.MaxValue;
        while(left<=right){
            int mid=(left+right)/2;
            if(nums[mid]>nums[right]){
                left=mid+1;
            }
            else{
                right=mid-1;
                min=Math.Min(nums[mid],min);
            }
        }
        return min;
    }
}
