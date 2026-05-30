public class Solution {
    public int LargestRectangleArea(int[] heights) {
        int n=heights.Length;
        int[] smallestOnRight=new int[n];
        int[] smallestOnLeft=new int[n];
        Stack<int> stack=new();

        for(int i=n-1;i>=0;i--){
            while(stack.Count!=0&& heights[stack.Peek()]>heights[i]){
                smallestOnLeft[stack.Peek()]=i;
                stack.Pop();
            }
            stack.Push(i);
        }
        while(stack.Count>0){
            smallestOnLeft[stack.Peek()]=-1;
            stack.Pop();
        }
           for(int i=0;i<n;i++){
            while(stack.Count!=0&& heights[stack.Peek()]>heights[i]){
                smallestOnRight[stack.Peek()]=i;
                stack.Pop();
            }
            stack.Push(i);
        }
        while(stack.Count>0){
            smallestOnRight[stack.Peek()]=n;
            stack.Pop();
        }
        int maxArea=0;
        for(int i=0;i<n;i++){
            maxArea=Math.Max(maxArea,(heights[i]*(smallestOnRight[i]-smallestOnLeft[i]-1)));
        }
        return maxArea;

    }
}
