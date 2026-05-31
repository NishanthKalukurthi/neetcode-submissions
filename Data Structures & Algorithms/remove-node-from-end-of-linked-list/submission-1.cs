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
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        ListNode prev=new ListNode(0,head);
        ListNode dummy=prev;
        
        ListNode cur=head;
        if(head==null||head.next==null) return null;
        for(int i=0;i<n;i++){
            cur=cur.next;
        }
        while(cur!=null){
            prev=prev.next;
            cur=cur.next;
        }
        prev.next=prev.next.next;

        return dummy.next;
       

    }
}
