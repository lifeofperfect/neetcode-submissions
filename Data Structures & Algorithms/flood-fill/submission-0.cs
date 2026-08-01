public class Solution {
    public int[][] FloodFill(int[][] image, int sr, int sc, int color) {
        if(image == null){
            return image;
        }

        if(image[sr][sc] == color){
            return image;
        }

        int originalColor = image[sr][sc];

        FloodFillColor(image, sr, sc, color, originalColor);

        return image;
    }

    public void FloodFillColor(int[][] image, int row, int col, int color, int originalColor){
        int rows = image.Length;
        int cols = image[0].Length;

        if(row < 0 || row >= rows || col < 0 || col >= cols){
            return;
        }

        if(image[row][col] != originalColor){
            return;
        }

        image[row][col] = color;

        FloodFillColor(image, row, col-1, color, originalColor);
        FloodFillColor(image, row, col+1, color, originalColor);
        FloodFillColor(image, row-1, col, color, originalColor);
        FloodFillColor(image, row+1, col, color, originalColor);
        
    }
}