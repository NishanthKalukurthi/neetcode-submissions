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
    public ListNode MergeKLists(ListNode[] lists) {
        //loop through all nodes add in the lists
        //sort the list and create linkedlist 
        //O(nlogn) O(n) extraspace

        ListNode dummy =new ListNode(0);
       // 1 2 4
       //1 3 5
        foreach(var lister in lists){
             ListNode temp=dummy;
             var list=lister;
             while(list!=null){
                if(temp.next==null)
                {
                    temp.next=list;
                    break;
                }
                else{
                    while(temp.next!=null && temp.next.val<list.val){
                        temp=temp.next;
                    } 
                    var listNxt=list.next;
                    list.next=temp.next;
                    temp.next=list;
                    temp=list;
                    list=listNxt;
                }
             }
        }

        return dummy.next;
    }
}
