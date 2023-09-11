using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms
{
    //LEETCODE :2215. Find the Difference of Two Arrays
    //Find difference and do distinct coz in problem it says no repetation allowed

    public class DifferenceOfTwoArrays
    {
        public IList<IList<int>> FindDifference(int[] nums1, int[] nums2)
        {
            var result = new List<IList<int>>(); 
            List<int> diff1 = nums1.Where(x => !nums2.Contains(x)).Distinct().ToList();
            List<int> diff2 =  nums2.Where(x=> !nums1.Contains(x)).Distinct().ToList();
            result.Add(diff1);
            result.Add(diff2);
            return result;
        }
    }
}
