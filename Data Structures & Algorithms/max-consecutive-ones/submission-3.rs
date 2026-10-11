impl Solution {
    pub fn find_max_consecutive_ones(nums: Vec<i32>) -> i32 {
        let mut better = 0;
        let mut actual = 0;

        for n in nums {
            if n == 1 {
                actual += 1;
                better = better.max(actual);
            } else {
                actual = 0;
            }
        }

        better
    }
}
