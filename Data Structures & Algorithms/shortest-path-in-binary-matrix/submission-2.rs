impl Solution {
    pub fn shortest_path_binary_matrix(grid: Vec<Vec<i32>>) -> i32 {
        let n = grid.len();
        if grid[0][0] == 1 || grid[n - 1][n - 1] == 1 {
            return -1;
        }

        let directions: [(i32, i32); 8] = [
            (0, 1), (1, 0), (0, -1), (-1, 0),
            (1, 1), (-1, -1), (1, -1), (-1, 1),
        ];
        let mut visit = vec![vec![false; n]; n];
        let mut q: VecDeque<(usize, usize, i32)> = VecDeque::new();
        q.push_back((0, 0, 1));
        visit[0][0] = true; 

        while let Some((r, c, length)) = q.pop_front() {
            if r == n - 1 && c == n - 1 {
                return length;
            }
            for &(dr, dc) in &directions {
                let (nr, nc) = (r as i32 + dr, c as i32 + dc);
                if nr >= 0 && nc >= 0 && nr < n as i32 && nc < n as i32 {
                    let (nr, nc) = (nr as usize, nc as usize);
                    if grid[nr][nc] == 0 && !visit[nr][nc] {
                        q.push_back((nr, nc, length + 1));
                        visit[nr][nc] = true;
                    }
                }
            }
        }
        -1              
    }
}
