using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms
{
    //LEETCODE: 1470. Shuffle the Array

    public class ShuffleArray
    {

        //Input [2,5,1,3,4,7 ];
        //Outut [2,3,5,4,1,7] 
        public int[] ShuffleArrayFunc(int[] nums, int n)
        {

            var result = new int[nums.Length];
            var index = 0;

            for (int i = 0; i < n; i++)
            {
                result[index++] = nums[i];
                result[index++] = nums[n + i];
            }

            return result;
        }

    }
}
