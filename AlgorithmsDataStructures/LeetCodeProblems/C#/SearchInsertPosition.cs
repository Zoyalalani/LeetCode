using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms
{
    public  class SearchInsertPosition
    {
        public int SearchNewInsertPosition(int target) {
            int[] nums = new int[5] { 1, 3, 5, 6, 8 };
            for (int i=0; i<nums.Length; i++)
            {
                if (nums[i] >= target)
                {
                    return i;
                }

            }
            return nums.Length;

        }
    }
}
