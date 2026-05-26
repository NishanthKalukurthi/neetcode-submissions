public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        int length=temperatures.Length;
        int[] result=new int[length];
        Stack<(int value , int index)> stack=new();
        for(int i=0;i<length;i++){
           
                while(stack.Count!=0 &&stack.Peek().value<temperatures[i]){
                    int idx=stack.Pop().index;
                    result[idx]=i-idx;
                }
                stack.Push((temperatures[i],i));
        }
        return result;
    }
}
