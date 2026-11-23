/*
Lab 3.3
3. Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
You may assume that each input would have exactly one solution, and you may not use the same element twice.
Input: nums = [2,7,11,15], target = 9
Output: [0,1]
Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
*/

int[] nums = [ 2, 7, 11, 15 ];

int target = 17;

int[] result = TargetFinder(nums, target);
Console.WriteLine($"Array is: [{string.Join(", ", nums)}]");
Console.WriteLine($"Target is {target}");
Console.WriteLine($"indeces that add to target: [{result[0]}], [{result[1]}]");

int[] TargetFinder(int[] nums, int target)

{
    Dictionary<int,int> seen = new();

    for ( int i = 0; i < nums.Length ; i++ )
    {
        int needed = target - nums[i];
        if (seen.TryGetValue(needed, out int index))
        {
            return [index, i];
        }

        seen[nums[i]] = i;

    }

    return [];
    
}
