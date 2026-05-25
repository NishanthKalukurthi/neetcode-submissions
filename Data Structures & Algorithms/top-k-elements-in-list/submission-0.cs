public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int,int> mapper=new();
        foreach(var num in nums){
            if(mapper.ContainsKey(num)){
                mapper[num]++;
            }
            else{
                mapper.Add(num,1);
            }
        }
        PriorityQueue<int,int> pq=new PriorityQueue<int,int>(Comparer<int>.Create((a,b)=>b.CompareTo(a)));

        foreach(var ch in mapper){
            pq.Enqueue(ch.Key,ch.Value);
        }
        int[] result=new int[k];
        int i=0;
        while(i<k){
            result[i++]=pq.Dequeue();
        }
        return result;
    }
}
