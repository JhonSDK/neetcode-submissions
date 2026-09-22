impl Solution {
    pub fn flood_fill(mut image: Vec<Vec<i32>>, sr: i32, sc: i32, color: i32) -> Vec<Vec<i32>> {
        let orig = image[sr as usize][sc as usize];
        if orig == color {
            return image;
        }
        Self::dfs(&mut image, sr, sc, orig, color);
        image
    }

    fn dfs(image: &mut [Vec<i32>], r: i32, c: i32, orig: i32, color: i32) {
        if r < 0 || c < 0 {
            return;
        }
        let (ru, cu) = (r as usize, c as usize);
        if ru >= image.len() || cu >= image[0].len() || image[ru][cu] != orig {
            return;
        }
        image[ru][cu] = color;
        Self::dfs(image, r + 1, c, orig, color);
        Self::dfs(image, r - 1, c, orig, color);
        Self::dfs(image, r, c + 1, orig, color);
        Self::dfs(image, r, c - 1, orig, color);
    }
}