public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        if(h<piles.Length) return -1;
        int min=1;
        int max=piles[0];
        foreach(var pile in piles){
            if(pile > max) max=pile;
           
        }
        int result=int.MaxValue;
        while(min<=max){
            int mid=(min+max)/2;
            int curHours=0;
             foreach(var pile in piles){
                    curHours+=(int)Math.Ceiling((double)pile/mid);
            }
            if(curHours<=h){
                result=Math.Min(result,mid);
                max=mid-1;
            }
            else{
                min=mid+1;
            }
        }
        return result;
    }
}
