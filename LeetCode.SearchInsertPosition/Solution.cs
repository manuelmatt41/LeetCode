using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.SearchInsertPosition
{
    public class Solution
    {
        public int SearchInsert(int[] nums, int target)
        {
            int index = Array.FindIndex(nums, n => n >= target);
            return index != -1 ? index : nums.Length;
        }
    }
}
