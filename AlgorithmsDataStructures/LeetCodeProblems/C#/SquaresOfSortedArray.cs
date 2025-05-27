using LeetCode.Algorithms;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms
{

    //LEETCODE 977. Squares of a Sorted Array

    internal class SquaresOfSortedArray
    {
        public int[] SquaresOfSortedArrayFunc(int[] nums)
        {
            int[] result = new int[nums.Length];
            for(int i=0; i<nums.Length; i++)
            {
                result[i] = nums[i] * nums[i];
            }
            return result.OrderBy(x => x).ToArray();
        }
    }
}

// -4, -1, 0, 3, 10 
