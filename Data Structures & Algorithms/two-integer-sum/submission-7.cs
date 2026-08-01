public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> seen = new Dictionary<int, int>();

        for(int i=0; i< nums.Length; i++){
            int current = nums[i];

            int diff = target - current;

            if(seen.ContainsKey(diff)){
                return new int[]{seen[diff], i};
            }

            seen[current] = i;
        }

        return new int[]{};
     }
}
