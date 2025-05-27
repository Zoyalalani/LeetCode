using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms
{
    //LEETCODE: 961. N-Repeated Element in Size 2N Array
    //Use GroupBy to group commmon elements
    //Use Count to match with count you want
    //Use select to get the element
    public class NRepeatedElements
    {
        //2,1,2,5,3,2
        //repCount = 3
        //num = 2
        public int NRepeatedElementsFunc(int[] nums)
        {
            int repCount = nums.Length/2;

            var group = nums.GroupBy(x => x).Where(x=>x.Count() == repCount).Select(x=>x.FirstOrDefault()).ToList();
            return group[0];
        }
    }
}
