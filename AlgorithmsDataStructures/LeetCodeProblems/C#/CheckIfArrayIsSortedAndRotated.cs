using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCodeProblems
{
    public class CheckIfArrayIsSortedAndRotated
    {
        public bool check(int[] nums)
        {
            //Find minimum element
            //Both left and right of that min element should be increasing
            //[3,4,5,1,2]
            //LEETCODE:1752. Check if Array Is Sorted and Rotated

            var minElemnet = nums.ToList().Min();
            var minIndex = nums.ToList().FindIndex(x => x == minElemnet);
            //Check for strict ascending as well 
            //example [1,2,3] is still rotated
            bool flag1 = true;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] > nums[i + 1])
                {
                    flag1 = false;
                    break;
                }
            }
            bool flag2 = true;
            for (int i = minIndex + 1; i < nums.Length; i++)
            {
                if (nums[i] < nums[i - 1])
                {
                    flag2 = false;
                    break;
                }
            }
            bool flag3 = true;
            for (int i = 1; i < minIndex; i++)
            {
                if (nums[i] < nums[i - 1])
                {
                    flag3 = false;
                    break;
                }
            }
            

            // Check if last element of the array
            // is smaller than the element just
            // before the element at minIndex
            // starting element of the array
            // for arrays like [3,4,6,1,2,5] - not circular
            // array
            if (flag1)
            {
                return true;
            }
            if (flag2 && flag3 && (nums[nums.Length - 1] <= nums[0]))
                return true;
            else
                return false;
        }
    }
}
