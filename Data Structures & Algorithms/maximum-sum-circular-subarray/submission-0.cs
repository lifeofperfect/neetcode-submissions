public class Solution {
    public int MaxSubarraySumCircular(int[] nums) {
        //1. find the max sum suing kadane's algo

        var maxLinearSum = nums[0];
        var currentSum = nums[0];

        for (var i = 1; i < nums.Length; i++)
        {
            currentSum = Math.Max(nums[i], currentSum + nums[i]);

            maxLinearSum = Math.Max(currentSum, maxLinearSum);
        }

        // find the wraparound
        //a find the total sum of all element
        //b run a min kadane on all element
        // max wrap around = total sum - min

        var totalSum = nums[0];

        var minimumSubarray = nums[0];
        var currentMinSubArray = nums[0];

        for (var i = 1; i < nums.Length; i++)
        {
            totalSum += nums[i];
            currentMinSubArray = Math.Min(nums[i], currentMinSubArray + nums[i]);
            minimumSubarray = Math.Min(minimumSubarray, currentMinSubArray);
        }

        if (totalSum == minimumSubarray)
            return maxLinearSum;

        var maxWrapAround = totalSum - minimumSubarray;

        return Math.Max(maxLinearSum, maxWrapAround);
    }
}