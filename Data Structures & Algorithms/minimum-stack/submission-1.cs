public class MinStack {
    private readonly Stack<(int value,int min)> stack;
    
    public MinStack() {
        stack=new();
      
    }
    
    public void Push(int val) {
       int currentMin= stack.Count==0?val:Math.Min(stack.Peek().min,val);
       stack.Push((val ,currentMin));

    }
    
    public void Pop() {
        if(stack.Count==0) return;
        stack.Pop();
       
    }
    
    public int Top() {
        return stack.Peek().value;
    }
    
    public int GetMin() {
        return stack.Peek().min;
    }
}
