using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms
{
    //1394. Find Lucky Integer in an Array

    public class LuckyInt
    {
        public int FindLucky(int[] arr)
        {
            List<int> listOfLuckyInt = arr.ToList();

            var luckyInts = listOfLuckyInt.Where(x => x == (listOfLuckyInt.Count(y=> y == x))).ToList();  
            return luckyInts.Count > 0 ? luckyInts.Max():  -1;


        }
    }
}
