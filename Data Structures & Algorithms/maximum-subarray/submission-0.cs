public class Solution {
    public int MaxSubArray(int[] nums) {
        // kadane's algorithm 

        var currentSum = nums[0];
        var maxSum = nums[0];

        for (var i = 1; i < nums.Length; i++)
        {
            currentSum = Math.Max(nums[i], currentSum + nums[i]);

            if (currentSum > maxSum)
                maxSum = currentSum;
        }

        return maxSum;
    }
}
