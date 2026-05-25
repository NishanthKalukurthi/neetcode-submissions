public class MinStack {
    private readonly Stack<int> stack;
    private readonly Stack<int> minTracker;
    public MinStack() {
        stack=new();
        minTracker=new();
    }
    
    public void Push(int val) {
        if(stack.Count==0){
            
            minTracker.Push(val);
        }
        else{
            minTracker.Push(Math.Min(minTracker.Peek(),val));
        }

        stack.Push(val);

    }
    
    public void Pop() {
        if(stack.Count==0) return;
        stack.Pop();
        minTracker.Pop();
    }
    
    public int Top() {
        return stack.Peek();
    }
    
    public int GetMin() {
        return minTracker.Peek();
    }
}
