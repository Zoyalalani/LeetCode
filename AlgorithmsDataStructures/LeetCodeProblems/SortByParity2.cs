using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms
{

    //LEETCODE 922. Sort Array By Parity II
    //maintain 2 separate index for even and odd starting at 0 and 1
    ///and increment with 2 for next insert
    public class SortByParity2
    {
        public int[] SortByParity2Func(int[] nums)
        {
            int j = 0;
            int k = 1;
            int[] resultArray = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    resultArray[j] = nums[i];
                    j += 2;
                }
                if (nums[i] % 2 == 1)
                {
                    resultArray[k] = nums[i];
                    k += 2;
                }
            }
            return resultArray;
        }
    }
}
