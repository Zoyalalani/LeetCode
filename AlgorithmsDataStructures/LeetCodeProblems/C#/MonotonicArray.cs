using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//It's monotone increasing if there aren't some adjacent values A[i], A[i+1]
//with A[i] > A[i+1], and similarly for monotone decreasing.
//LEETCODE 896. Monotonic Array

namespace LeetCode.Algorithms
{
    public class MonotonicArray
    {
        public bool MonotonicArrayFun(int[] nums)
        {
            bool increasing = true;
            bool decreasing = true;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] > nums[i + 1])
                {
                    increasing = false;
                }
                if (nums[i] < nums[i + 1])
                {
                    decreasing = false;
                }
            }
            return increasing || decreasing;
        }
    }
}


//length = 4
//0,1,2,3
//2,3,5,8
//8,5,3,2
//2,8,3,5