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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        ListNode dummy=new ListNode(0);
        ListNode head=dummy;
        if(list1==null) return list2;
        if(list2==null) return list1;

        while(list1!=null && list2!=null){
                if(list1.val<=list2.val){
                    ListNode temp=list1.next;
                    dummy.next=list1;
                    dummy=list1;
                    list1=temp;
                }
                else{
                    ListNode temp1=list2.next;
                    dummy.next=list2;
                    dummy=list2;
                    list2=temp1;
                }
        }
        if(list2!=null){
            dummy.next=list2;
        }
        if(list1!=null){
            dummy.next=list1;
        }


        return head.next;
    }
}