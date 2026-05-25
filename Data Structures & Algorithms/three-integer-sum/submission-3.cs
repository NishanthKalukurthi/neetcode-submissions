public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);
        List<List<int>> result=new();
        for(int i=0;i<nums.Length;i++){
            if(nums[i]>0) break;
            if(i>0&&nums[i]==nums[i-1]) continue;
            int target=nums[i];
           int j=i+1; int k=nums.Length-1;
           while(j<k)
           {
            if(nums[j]+nums[k]+target>0){
                k--;
            }
            else if(nums[j]+nums[k]+target<0){
                j++;
                
            }
            else{
                result.Add(new List<int>{nums[i],nums[j],nums[k]});
                j++;
                k--;
                while(j<k&&nums[j]==nums[j-1]){
                    j++;
                }
                
            }
           }
        }
        return result;
    }
}
