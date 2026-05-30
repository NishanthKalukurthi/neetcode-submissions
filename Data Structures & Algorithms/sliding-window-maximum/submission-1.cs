public class Solution {
    public int[] MaxSlidingWindow(int[] nums, int k) {
        var deque=new LinkedList<(int idx,int value)>();
        int[] output =new int[nums.Length-k+1];
        for(int i=0;i<k;i++){
            while(deque.Count>0&& deque.Last.Value.value<nums[i]){
                deque.RemoveLast();
            }
            deque.AddLast((i,nums[i]));
        }
        output[0]=deque.First.Value.value;


        for(int i=0;i<nums.Length-k;i++){
             while(deque.Count>0&& deque.Last.Value.value<nums[i+k]){
                deque.RemoveLast();
            }
            deque.AddLast((i+k,nums[i+k]));
            while(deque.Count>0&& deque.First.Value.idx<i+1){
                deque.RemoveFirst();
            }
            output[i+1]=deque.First.Value.value;
        }

        return output;
    }
}
