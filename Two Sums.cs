/*
Given an array of integers, return indices of the two numbers such that they add up to a specific target.

You may assume that each input would have exactly one solution, and you may not use the same element twice.

Example:

Given nums = [2, 7, 11, 15], target = 9,

Because nums[0] + nums[1] = 2 + 7 = 9,
return [0, 1].
*/

public class Solution {
    public int[] TwoSum(int[] nums, int target)
        {
            var visited = new Dictionary<int, int>();

            for(int i = 0; i < nums.Length; i++)
            {
                if(visited.ContainsKey(target - nums[i]))
                {
                    return new int[] { visited[target-nums[i]], i };
                }
                else
                {
                    if(!visited.ContainsKey(nums[i]))
                    {
                        visited.Add(nums[i], i);   
                    }
                }
            }

            return new int[2];
        }
}
