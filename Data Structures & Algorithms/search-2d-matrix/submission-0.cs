public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int row=matrix.Length;
        int col=matrix[0].Length;

        for(int i=0;i<row;i++){
            int start=0;
            int end=col-1;
            while(start<=end){
                int mid=(start+end)/2;
                if(matrix[i][mid]==target) return true;
                else if(matrix[i][mid]<target){
                    start=mid+1;
                }
                else{
                    end=mid-1;
                }
            }
        }

        return false;
    }
}
