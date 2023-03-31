using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.RomanToInteger
{
    public class Solution
    {
        public int RomanToInt(string s)
        {
            int result = 0;
            int[] romanNumbers = Array.ConvertAll(
                s.ToArray(), 
                new Converter<char, int>((c) => (int)Enum.Parse(typeof(RomanNumbers),c.ToString())));

            for (int i = 0; i < romanNumbers.Length; i++)
            {
                bool isLowerThanTheNextNumber = i < romanNumbers.Length - 1 && romanNumbers[i] < romanNumbers[i + 1];

                if (isLowerThanTheNextNumber)
                {
                    result += romanNumbers[i + 1] - romanNumbers[i];
                    i++;
                }
                else
                {
                    result += (int)romanNumbers[i];
                }
            }

            return result;
        }

        enum RomanNumbers
        {
            I = 1, 
            V = 5, 
            X = 10, 
            L = 50,
            C = 100,
            D = 500,
            M = 1000
        }
    }
}
