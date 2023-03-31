using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LongestCommonPrefix
{
    public class Solution
    {
        public string LongestCommonPrefix(string[] strs)
        {
            if (string.IsNullOrWhiteSpace(strs[0]) || strs.Length == 0)
            {
                return "";
            }

            if (!Array.TrueForAll(strs, s => s.StartsWith(strs[0][0])))
            {
                return "";
            }

            string prefix = strs[0][0].ToString();

            for (int i = 1; i < strs[0].Length; i++)
            {
                char nextLetter = strs[0][i];
                if (!Array.TrueForAll(strs, s => s.StartsWith(prefix + nextLetter)))
                {
                    return prefix;
                }
                    prefix += nextLetter;
            }

            return prefix;
        }
    }
}
