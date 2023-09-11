using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms
{
    public class ElementAppearingMoreThanXTimes
    {
        //1287. Element Appearing More Than 25% In Sorted Array
        public int FindSpecialInteger(int[] arr)
        {
            var length = arr.Count();
            //find element repeating 25% of times

            var repeatTimes = 0.25 * length;

            var element = arr.ToList().GroupBy(x=>x).ToList();

            return element.Where(x => x.Count() > repeatTimes).First().Key;

            



        }
    }
}
