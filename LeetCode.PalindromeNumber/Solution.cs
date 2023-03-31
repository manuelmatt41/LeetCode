using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.PalindromeNumber
{
    public class Solution
    {
        public bool IsPalindrome(int x)
        {
            string stringNumber = x.ToString();
            int start = 0;
            int end = stringNumber.Length - 1;

            while (start < end)
            {
                if (stringNumber[start] != stringNumber[end]) 
                {
                    return false;
                }
                start++;
                end--;
            }
            
            return true;
        }
    }
}
