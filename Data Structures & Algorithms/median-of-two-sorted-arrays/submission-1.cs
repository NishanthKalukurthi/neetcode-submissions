public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
         if(nums1.Length > nums2.Length)
        return FindMedianSortedArrays(nums2, nums1);

        int m=nums1.Length;
        int n=nums2.Length;
        int total=m+n;
        int half= (total+1)/2;
        int l=0; int r=m;
        // if(m<n) r=m-1;
        // else r=n-1;
        while(true){
            int mid=(l+r)/2; //nums1 0
            int nums2Index= half-mid;

            int Left1 = mid>0? nums1[mid-1]:int.MinValue;
            int Right1 = mid<m ? nums1[mid]:int.MaxValue;
             int Left2 = nums2Index>0? nums2[nums2Index-1]:int.MinValue;
            int Right2 = nums2Index<n ? nums2[nums2Index]:int.MaxValue;

            if(Left1<=Right2 && Left2<=Right1){
                if(total%2==0){
                    return (double)(Math.Max(Left1,Left2)+Math.Min(Right1,Right2))/2;
                }
                else return (double) Math.Max(Left1,Left2);
            }
            else if(Left1>Right2){
                r=mid-1;
            }
            else l=mid+1;
        }

    }
}
