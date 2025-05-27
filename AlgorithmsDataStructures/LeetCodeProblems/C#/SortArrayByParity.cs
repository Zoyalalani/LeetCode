using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Write all the even elements first, then write all the odd elements.
//LEETCODE 905. Sort Array By Parity

namespace LeetCode.Algorithms
{
    internal class SortArrayByParity
    {
        public int[] SortArrayByParityFun(int[] nums)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    result.Add(nums[i]);
                }

            }
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 1)
                {
                    result.Add(nums[i]);
                }

            }
            return result.ToArray();
        }
    }
}

