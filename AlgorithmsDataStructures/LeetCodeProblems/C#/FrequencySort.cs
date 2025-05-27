using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms
{
    //LEETCODE: 1636. Sort Array by Increasing Frequency

    public class FrequencySort
    {
        //Input: nums = [1,1,2,2,2,3]
        //Output: [3,1,1,2,2,2]
        public int[] FrequencySortFunc(int[] nums)
        {
            var groups = nums.OrderByDescending(x => x).GroupBy(x => x);
            var sortedGroups = groups.OrderBy(x => x.Count()).SelectMany(gr=>gr).ToArray();
            return sortedGroups;

        }
    }
}
