using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms
{
    public class RemoveOccuranceOfTarget
    {
        public int RemoveAllOccuranceOfTarget(int num)
        {
            int[] arr = new int[8] { 0, 1, 2, 2, 3, 0, 4, 2 };
            List<int> list = new List<int>(arr);
            list.RemoveAll(x => x == num);
            return list.Count;
        }
    }
}
