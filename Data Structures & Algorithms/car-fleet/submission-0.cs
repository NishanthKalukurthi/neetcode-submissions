public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
        
    int n=position.Length;
    int[][] pairs=new int[n][];
    for(int i=0;i<n;i++){
        pairs[i]=new int[]{position[i],speed[i]};
    }  
    Array.Sort(pairs,(a,b)=>b[0].CompareTo(a[0]));
     int noOfCarFleets=1;
    
    double prevTime= (double)(target-pairs[0][0])/pairs[0][1];

    for(int i=1;i<n;i++){
        double currentTime= (double)(target-pairs[i][0])/pairs[i][1];
        if(currentTime>prevTime){
            noOfCarFleets++;
            prevTime=currentTime;
        }
    }

        
    return noOfCarFleets;
    }
}
