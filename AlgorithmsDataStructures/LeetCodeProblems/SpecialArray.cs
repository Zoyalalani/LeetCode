using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms
{
    public class SpecialArray
    {
        //LEETCODE : 1608: special-array-with-x-elements-greater-than-or-equal-x
        public int SpecialArrayFunc(int[] nums)
        {
            int[] tempArray = new int[nums.Max()+1];
            for(int i=0; i<=nums.Max(); i++)
            {
                tempArray[i] = i;
            }
            var result = tempArray.Where(x => x == (nums.Where(y => y >= x).Count())).ToList();
            return result.Count > 0 ? result[0] : -1;
        }
    }
}

