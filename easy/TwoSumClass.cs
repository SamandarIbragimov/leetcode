namespace leetcode.easy
{
    public class TwoSumClass
    {
        public int[] TwoSum(int[] nums, int target) 
        {
            var dict = new Dictionary<int,int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int diff = target - nums[i];
                if(dict.ContainsKey(diff))
                {
                    return new int[]{dict[diff],i};
                }
                dict[nums[i]] = i;
            }
            throw new ArgumentException("No solution found");
        }
    }
}