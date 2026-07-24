public class Solution {
    public bool hasDuplicate(int[] nums) {
        Dictionary<int, int> countMap = new Dictionary<int, int>();
        foreach (int num in nums){
                if (!countMap.ContainsKey(num)){
                        countMap.Add(num, 1);
                }
                else{
                        countMap.TryGetValue(num, out int val);
                        countMap[num] = val + 1;
                        return true;
                }
        }
        return false;
    }
}