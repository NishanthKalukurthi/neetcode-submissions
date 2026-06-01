/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */

public class Solution {
    public void ReorderList(ListNode head) {
        if(head.next==null || head==null) return;
        ListNode slow=head;
        ListNode fast=head.next.next;
    
        while(fast!=null && fast.next!=null){
            fast=fast.next.next;
            slow=slow.next;
        }
        ListNode reverse=Reverse(slow.next);
        slow.next=null;
        ListNode current=head;
        while(current.next!=null){
            ListNode temp=reverse.next;
            reverse.next=current.next;
            current.next=reverse;
            current=current.next.next;
            reverse=temp;
        }
        current.next=reverse;

 


    }
    private ListNode Reverse(ListNode head){
        ListNode prev=null;
        ListNode cur=head;
        while(cur!=null){
            ListNode temp=cur.next;
            cur.next=prev;
            prev=cur;
            cur=temp;
        }

        return prev;
    }
}
