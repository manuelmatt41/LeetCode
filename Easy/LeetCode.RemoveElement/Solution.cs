using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.RemoveElement
{
    internal class Solution
    {
        public int RemoveElement(int[] nums, int val)
        {
            var sortedList = nums.ToList();
            sortedList.RemoveAll(n => n == val);
            Console.Write(Array.IndexOf(nums, 5));
            for (int i = 0; i < sortedList.Count; i++)
            {
                nums[i] = sortedList[i];
            }

            return sortedList.Count;
        }
    }
}
