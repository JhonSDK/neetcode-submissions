impl Solution {
    pub fn find_max_consecutive_ones(nums: Vec<i32>) -> i32 {
        nums.split(|&n| n == 0).map(|grupo| grupo.len()).max().unwrap_or(0) as i32
    }
}
