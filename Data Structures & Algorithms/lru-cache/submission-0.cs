public class Node{
    public Node Next{get; set;}
    public Node Prev{get; set;}
    public int key;
    public int val;
    public Node(int _key,int _val){
        key=_key;
        val=_val;
        Next=null;
        Prev=null;
    }
}


public class LRUCache {
    private readonly int _capacity;
    private readonly Dictionary<int ,Node> map;
    private Node left;
    private Node right;
    public int count;
    
    public LRUCache(int capacity) {
        _capacity=capacity;
        map=new();
        left=new Node(0,0);
        right=new Node(0,0);
        left.Next=right;
        right.Prev=left;
        count=0;
    }
    
    public int Get(int key) {
        if(!map.ContainsKey(key)) return -1;
        var existingNode=map[key];
            var nxtNode=existingNode.Next;
            nxtNode.Prev=existingNode.Prev;
            existingNode.Prev.Next=nxtNode;
        Node current =existingNode;
        var firstNode=left.Next;
            left.Next=current;
            current.Prev=left;
            current.Next=firstNode;
            firstNode.Prev=current;
         return current.val;

    }
    
    public void Put(int key, int value) {
         Node current;
        if(!map.ContainsKey(key)){
            if(count==_capacity){
                var last=right.Prev;
                right.Prev=last.Prev;
                right.Prev.Next=right;
                map.Remove(last.key);
                count--;
            }
             current=new Node(key,value);
             count++;
            
        }
        else{
            var existingNode=map[key];
            var nxtNode=existingNode.Next;
            nxtNode.Prev=existingNode.Prev;
            existingNode.Prev.Next=nxtNode;
            existingNode.val=value;
            current=existingNode;

        }

            var firstNode=left.Next;
            left.Next=current;
            current.Prev=left;
            current.Next=firstNode;
            firstNode.Prev=current;

            map[key]=current;

        
        
    }
}
