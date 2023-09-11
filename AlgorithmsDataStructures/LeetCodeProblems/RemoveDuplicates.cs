using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms
{
    public class RemoveDuplicates
    {
        public int[] RemoveDuplicatesFromArray()
        {
            int[] arr = new int[8] { 1, 1, 3, 3, 5, 5, 5, 8 };
            List<int> newList = new List<int>(arr);
            var a = newList.Distinct();
            return a.ToArray();

        }
    }
}
