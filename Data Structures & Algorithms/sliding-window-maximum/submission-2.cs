public class Solution {
    public int[] MaxSlidingWindow(int[] nums, int k) {
        var deque=new LinkedList<int>();
        int[] output =new int[nums.Length-k+1];
        for(int i=0;i<k;i++){
            while(deque.Count>0&& nums[deque.Last.Value]<nums[i]){
                deque.RemoveLast();
            }
            deque.AddLast(i);
        }
        output[0]=nums[deque.First.Value];


        for(int i=0;i<nums.Length-k;i++){
             while(deque.Count>0&& nums[deque.Last.Value]<nums[i+k]){
                deque.RemoveLast();
            }
            deque.AddLast(i+k);
            while(deque.Count>0&& deque.First.Value<i+1){
                deque.RemoveFirst();
            }
            output[i+1]=nums[deque.First.Value];
        }

        return output;
    }
}
