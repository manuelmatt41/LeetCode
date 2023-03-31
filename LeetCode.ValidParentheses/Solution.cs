using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.ValidParentheses
{
    public class Solution
    {
        public bool IsValid(string s)
        {
            if (s.Length % 2 != 0) return false;

            List<char> unboundedBrackets = new List<char>();
            bool isValidBracket = false;

            for (int i = 0; i < s.Length; i++)
            {
                bool isOpenBracket = s[i] == '(' || s[i] == '[' || s[i] == '{';
                bool isCloseBracket = s[i] == ')' || s[i] == ']' || s[i] == '}';

                if (isOpenBracket)
                {
                    unboundedBrackets.Add(s[i]);
                    continue;
                }

                if (unboundedBrackets.Count == 0)
                    return false;

                if (isCloseBracket)
                {
                    switch (unboundedBrackets.Last())
                    {
                        case '(':
                            isValidBracket = s[i] == ')';
                            break;
                        case '{':
                            isValidBracket = s[i] == '}';
                            break;
                        case '[':
                            isValidBracket = s[i] == ']';
                            break;
                    }
                }

                if (isValidBracket)
                {
                    unboundedBrackets.RemoveAt(unboundedBrackets.Count - 1);
                }
                else
                {
                    return false;
                }
            }
            return unboundedBrackets.Count == 0;
        }
    }
}
