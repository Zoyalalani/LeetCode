using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms
{

    //LEETCODE : 1122. Relative Sort Array

    public class RelativeSortArray
    {
        public int[] RelativeSortArrayFunc(int[] arr1, int[] arr2)
        {
           // Input: arr1 = [2, 3, 1, 3, 2, 4, 6, 7, 9, 2, 19],
           // arr2 = [2, 1, 4, 3, 9, 6]
          //  Output: [2,2,2,1,4,3,3,9,6,7,19]
              
            var resultList = new List<int>();
            var arr1List = arr1.ToList();
            var arr2List = arr2.ToList();
            var distinct = arr1.Where(x=>!arr2List.Contains(x)).OrderBy(x=>x).ToList();   

            foreach ( var item in arr2List )
            {
                if(arr1List.Contains(item))
                {
                    var count = arr1.Where(x => x == item).Count();
                    for(int i =0; i < count; i++)
                    {
                        resultList.Add(item);
                    }
                }
                
            }
            resultList.AddRange(distinct);
            return resultList.ToArray();
        }
       
    }
}
