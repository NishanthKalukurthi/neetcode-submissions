public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int row=matrix.Length;
        int col=matrix[0].Length;

        int top=0;int bot=row-1;
        while(top<=bot){
            int Row=(top+bot)/2;
            if(target>matrix[Row][col-1]){
                top=Row+1;
            }
            else if(target<matrix[Row][0]){
                bot=Row-1;
            } 
            else break;
        }

        if(!(top<=bot)) return false;
        int l=0;int r=col-1;
        int curRow=(top+bot)/2;
        while(l<=r){
            int mid=(l+r)/2;
            if(target<matrix[curRow][mid]) r=mid-1;
            else if(target>matrix[curRow][mid]) l=mid+1;
            else return true;
        }
        return false;
    }
}
