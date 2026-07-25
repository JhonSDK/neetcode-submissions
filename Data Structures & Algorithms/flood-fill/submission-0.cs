public class Solution {
    public int[][] FloodFill(int[][] image, int sr, int sc, int color) {
          int orig = image[sr][sc];
          if(orig == color)return image;
          int m = image.Length, n = image[0].Length;
          DFS(image, sr, sc, orig, color, m, n);
          return image;     
    }

    private void DFS(int[][] image, int r, int c, int orig, int color, int m, int n) {
        if (r < 0 || r >= m || c < 0 || c >= n || image[r][c] != orig) return;
        image[r][c] = color;
        DFS(image, r + 1, c, orig, color, m, n);
        DFS(image, r - 1, c, orig, color, m, n);
        DFS(image, r, c + 1, orig, color, m, n);
        DFS(image, r, c - 1, orig, color, m, n);
    }
}
