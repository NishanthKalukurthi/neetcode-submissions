/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;
    
    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
*/

public class Solution {
    public Node copyRandomList(Node head) {
        if(head==null) return null;
        Node cur=head;
        Dictionary<Node ,Node> oldToCopy=new();
        //oldToCopy[null]=null;
        while(cur!=null){
            Node copy=new Node(cur.val);
            oldToCopy[cur]=copy;
            cur=cur.next;
        }
        
        cur=head;
        while(cur!=null){
            var copy=oldToCopy[cur];
            copy.next= cur.next==null? null :oldToCopy[cur.next];
            copy.random=cur.random==null? null :oldToCopy[cur.random];
            cur=cur.next;
        }

        return oldToCopy[head];

    }
}
