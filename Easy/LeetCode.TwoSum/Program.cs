// See https://aka.ms/new-console-template for more information
using LeetCode.TwoSum;
using System.Linq;

Solution solution = new Solution();

Console.WriteLine($"[{string.Join(',', solution.TwoSum(new int[] { 2, 7, 11, 15 }, 9))}]");
Console.WriteLine($"[{string.Join(',', solution.TwoSum(new int[] { 3, 2, 4 }, 6))}]");
Console.WriteLine($"[{string.Join(',', solution.TwoSum(new int[] { 3, 3 }, 6))}]");