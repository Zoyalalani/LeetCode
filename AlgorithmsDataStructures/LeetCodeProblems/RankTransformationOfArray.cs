using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms
{
    public class RankTransformationOfArray
    {

        //1331. Rank Transform of an Array
        //Interesting C# problems

        public int[] ArrayRankTransform(int[] arr)
        {
            //arr = [40,10,10,20,30]
            var resultArray = new int[arr.Length];
            //sortedArray = 10,10,20,30,40
            var sortedArray = arr.ToArray();
            Array.Sort(sortedArray);
            //Assign key value to sorted array in dictionary
            //key would be index, value will be the value
            Dictionary<int, int> dict = new Dictionary<int, int>();
            int rank = 1;
            foreach (int num in sortedArray)
            {
                if(!dict.ContainsKey(num))
                {
                    dict[num] = rank;
                    rank++;
                }
            }
            int[] result = new int[arr.Length];
            for(int i = 0; i < arr.Length; i++)
            {
                result[i] = dict[arr[i]];
            }
            return result;
        }
    }
}

