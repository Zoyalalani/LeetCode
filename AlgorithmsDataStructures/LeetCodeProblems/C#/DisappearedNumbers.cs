using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms
{
    public class DisappearedNumbers
    {
        public IList<int> DisappearedNums(int[] nums)
        {
            List<int> result = new List<int>();
            List<int> numsList = nums.ToList();
            ;
            for (int i = 1; i < nums.Length +1; i++)
            {
                if(!numsList.Contains(i))
                {
                    result.Add(i);
                }
            }
            return result;
        }
    }
}
