impl Solution {
    pub fn has_duplicate(nums: Vec<i32>) -> bool {
            let mut count_map: HashMap<i32, i32> = HashMap::new();

            for &num in nums.iter() {
                if count_map.contains_key(&num) {
                    return true;
                }
                count_map.insert(num, 1);
            }
            false
    }
}
