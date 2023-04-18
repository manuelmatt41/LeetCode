using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.MergeStringAlternately
{
    public class Solution
    {
        public string MergeAlternately(string word1, string word2)
        {
            string outputString = "";
            int maxWordLength = word1.Length > word2.Length ? word1.Length : word2.Length;

            for (int i = 0; i < maxWordLength; i++)
            {
                outputString += $"{(i < word1.Length ? word1[i] : "")}{(i < word2.Length ? word2[i] : "")}";
            }

            return outputString;
        }
    }
}
