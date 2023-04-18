using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LengthLastWord
{
    public class Solution
    {
        public int LengthOfLastWord(string s)
        {
            var words = s.Trim().Split(' ');
            return words[words.Length - 1].Length;
        }
    }
}
