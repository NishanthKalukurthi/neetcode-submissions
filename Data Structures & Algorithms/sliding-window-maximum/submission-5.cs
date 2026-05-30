public class Solution {
    public int[] MaxSlidingWindow(int[] nums, int k) {
        var deque=new LinkedList<int>();
        int[] output =new int[nums.Length-k+1];
        for(int i=0;i<k-1;i++){
            while(deque.Count>0&& nums[deque.Last.Value]<nums[i]){
                deque.RemoveLast();
            }
            deque.AddLast(i);
        }
        //output[0]=nums[deque.First.Value];


        for(int i=k-1;i<nums.Length;i++){
             while(deque.Count>0&& nums[deque.Last.Value]<nums[i]){
                deque.RemoveLast();
            }
            deque.AddLast(i);
            while(deque.Count>0&& deque.First.Value<=i-k){
                deque.RemoveFirst();
            }
            output[i+1-k]=nums[deque.First.Value];
        }

        return output;
    }
}
