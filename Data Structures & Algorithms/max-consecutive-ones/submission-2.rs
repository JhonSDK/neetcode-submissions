impl Solution {
    pub fn find_max_consecutive_ones(nums: Vec<i32>) -> i32 {
        let mut running_cnt = 0;
        let mut cnt = 0;
        for n in nums {
            if n == 0 {
                cnt = std::cmp::max(running_cnt, cnt);
                running_cnt = 0;
            } else {
                running_cnt += 1;
            }
        }
        std::cmp::max(running_cnt, cnt)
    }
}
