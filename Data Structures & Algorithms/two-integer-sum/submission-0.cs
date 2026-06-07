public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int ,int> map=new();

        for(int i=0;i<nums.Length;i++){
            int t=target-nums[i];

            if(map.ContainsKey(t)){
                return new int[]{map[t],i};
            }
            else{
                map[nums[i]]=i;
            }
        }

        return new int[]{-1,-1};
    }
}
