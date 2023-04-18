using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.RemoveDuplicatesFromSortedArray
{
    public class Solution
    {
        public int RemoveDuplicates(int[] nums)
        {
            List<int> filterList = new List<int>(nums.Length);

            filterList.AddRange(nums.Distinct());
            int k = filterList.Count;
            for (int i = 0; i < filterList.Count; i++)
            {
                nums[i] = filterList[i];
            }

            return k;
        }
    }
}
