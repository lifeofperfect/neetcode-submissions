public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> numSet = new HashSet<int>(nums);
        int longest = 0;

        foreach(int num in nums){
            if(!numSet.Contains(num-1)){
                int numy = num;
                int length = 1;

                while(numSet.Contains(numy + 1)){
                    length++;
                    numy++;
                }

                longest = Math.Max(longest, length);
            }
        }

        return longest;
    }
}
