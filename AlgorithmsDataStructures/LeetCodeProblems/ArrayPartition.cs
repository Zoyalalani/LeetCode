using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms
{

    //sort array and sum digits at even places to get max number
    //LEETCODE: 561
    public class ArrayPartition
    {
        public int ArrayPartitionFunc (int[] num)
        {
            List<int> sortedNums = num.OrderBy (i => i).ToList ();
            int maxSum = 0;
            for(int i=0; i< sortedNums.Count; i++)
            {
                if(i%2 == 0)
                {
                    maxSum += sortedNums[i];
                }
            }
            return maxSum;
        }
    }
}
