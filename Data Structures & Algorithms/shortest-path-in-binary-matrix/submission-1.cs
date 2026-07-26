public class Solution {
    public int ShortestPathBinaryMatrix(int[][] grid) {
        int n = grid.Length;
        if(grid[0][0] == 1 || grid[n - 1][n - 1] == 1) {
            return -1;
        }
        var q = new Queue<(int r, int c, int length)>();
        q.Enqueue((0,0,1));
        var visit = new HashSet<(int, int)> {(0,0)};
        (int dr, int dc)[] directions = new (int,int)[]{
            (0, 1), (1, 0), (0, -1), (-1, 0),
            (1, 1), (-1, -1), (1, -1), (-1, 1)
        };

        while (q.Count > 0) {
            var (r, c, length) = q.Dequeue();
            if (r == n - 1 && c == n - 1) {
                return length;
            }

            foreach (var (dr, dc) in directions) {
                int nr = r + dr, nc = c + dc;
                if (nr >= 0 && nr < n && nc >= 0 && nc < n
                    && grid[nr][nc] == 0
                    && !visit.Contains((nr, nc))) {
                    q.Enqueue((nr, nc, length + 1));
                    visit.Add((nr, nc));
                }
            }
        }
        return -1;
    }
}