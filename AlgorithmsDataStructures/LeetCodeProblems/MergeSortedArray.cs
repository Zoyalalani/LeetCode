using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms
{
    public class MergeSortedArray
    {
        public int[] MergeSortedArrayFun(int[] nums1, int[] nums2)
        {

            int[] result = nums1.Where(x=>nums2.Contains(x)).Concat(nums2.Where(y=>nums1.Contains(y))).ToArray();
            return result;

        }
    }
}



//1,2,3
//1,3,4,5