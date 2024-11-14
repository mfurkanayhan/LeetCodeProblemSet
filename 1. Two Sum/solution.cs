public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> seenNums = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++){
            int currentNum = nums[i];
            int complement = target - currentNum;

            if (seenNums.ContainsKey(complement)){
                return new int[] {seenNums[complement], i};
            }
            seenNums[currentNum] = i;
        }

        return new int[0];        
    }
}