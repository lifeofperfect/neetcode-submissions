public class Solution {
    public int MaxAreaOfIsland(int[][] grid) {
        int maxArea = 0;

        if(grid == null || grid.Length == 0){
            return maxArea;
        }

        for(int i=0; i< grid.Length; i++){

            for(int j=0; j<grid[0].Length; j++){

                if(grid[i][j] == 1){
                    int currentArea = CheckIslandArea(grid, i, j);

                    maxArea = Math.Max(maxArea, currentArea);
                }
            }
        }

        return maxArea;
    }

    public int CheckIslandArea(int[][] grid, int row, int col){
        int rows = grid.Length;
        int cols = grid[0].Length;
        

        if(row < 0 || row >= rows || col < 0 || col >= cols){
            return 0;
        }

        if(grid[row][col] == 0){
            return 0;
        }

        grid[row][col] = 0;

        int currentAreaCount = 1;

        int up = CheckIslandArea(grid, row, col-1);
        int down = CheckIslandArea(grid, row, col+1);
        int left = CheckIslandArea(grid, row - 1, col);
        int right = CheckIslandArea(grid, row +1, col);

        return currentAreaCount + up + down + left + right;
    }
}
