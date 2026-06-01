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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {

        if(l1==null) return l2;

        if(l2==null) return l1;
    
        ListNode dummy =new ListNode(0);
        ListNode current =dummy;
      
        int carry =0;

        while(l1!=null || l2!=null){

            int value1= (l1!=null)? l1.val:0;
            int value2 = (l2!=null)?l2.val:0;
            
            int sum =value1+value2+carry;

            int value =sum%10;
            carry = sum/10;

            ListNode node= new ListNode(value);
         
            current.next=node;

            current=node;
            if(l1!=null)l1=l1.next;
            if(l2!=null)l2=l2.next;

        }
        if(carry>0) current.next=new ListNode(carry);
        return dummy.next;
         

    }
}
