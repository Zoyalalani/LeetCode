using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms
{
    public class KNegations
    {
        public int KNegationsFunc(int[] nums, int k)
        {
            int i = 0;
            while (i < k)
            {
                Array.Sort(nums);
                nums[0] = -nums[0];
                i++;
            }
            return nums.Sum();

        }
    }
}
