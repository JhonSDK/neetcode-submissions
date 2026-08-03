impl Solution {
    pub fn replace_elements(mut arr: Vec<i32>) -> Vec<i32> {
            let mut max = -1;
            for n in arr.iter_mut().rev(){
                let current = *n;
                *n = max;
                max = max.max(current);
            }
            arr
    }
}
