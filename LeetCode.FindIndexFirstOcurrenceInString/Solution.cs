﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.FindIndexFirstOcurrenceInString
{
    public class Solution
    {
        public int StrStr(string haystack, string needle)
        {
            return haystack.IndexOf(needle);
        }
    }
}
