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
       List<int>[] list =new List<int>[nums.Length+1];

       foreach(var item in mapper){
            if(list[item.Value]==null){
                list[item.Value]=new List<int>();
            }
            list[item.Value].Add(item.Key);
       }
       
        int[] result=new int[k];
        int index = 0;

for(int i = list.Length - 1; i >= 0 && index < k; i--)
{
    if(list[i] != null)
    {
        foreach(var item in list[i])
        {
            result[index++] = item;

            if(index == k)
            {
                break;
            }
        }
    }
}

        return result;
    }
}
