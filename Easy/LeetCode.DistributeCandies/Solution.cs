using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.DistributeCandies
{
    public class Solution
    {
        public int DistributeCandies(int[] candyType)
        {
            int maxCandies = candyType.Length / 2;
            int diferentCandies = candyType.Distinct().Count();

            return maxCandies <= diferentCandies ? maxCandies : diferentCandies;
        }
    }
}
