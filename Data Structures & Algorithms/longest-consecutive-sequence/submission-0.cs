public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> set=new HashSet<int>(nums);
        int longestSequence=0;
        foreach(var num in nums){
            if(set.Contains(num-1)) continue;
            int length=0;
            while(set.Contains(num+length)){
                length++;
            }
            longestSequence=Math.Max(longestSequence,length);
        }
        return longestSequence;
    }
}
