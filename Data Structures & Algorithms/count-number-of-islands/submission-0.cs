public class Solution {
    public int NumIslands(char[][] grid) {
        int island = 0;
        if(grid == null || grid.Length == 0){
            return island;
        }

        for(int i=0; i< grid.Length; i++){

            for(int j=0; j<grid[0].Length; j++){

                if(grid[i][j] == '1'){
                    island++;

                    CheckAroundIsand(grid, i, j);
                }

            }
        }

        return island;
    }

    public void CheckAroundIsand(char[][] grid, int row, int col){
        int rows = grid.Length;
        int cols = grid[0].Length;

        if(row < 0 || row >= rows || col < 0 || col >= cols){
            return;
        }

        if(grid[row][col] == '0'){
            return;
        }

        grid[row][col] = '0';

        CheckAroundIsand(grid, row, col-1);
        CheckAroundIsand(grid, row, col+1);
        CheckAroundIsand(grid, row-1, col);
        CheckAroundIsand(grid, row+1, col);
    }
}
