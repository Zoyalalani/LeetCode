using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms
{
    public class ReverseString
    {
        // LEETCODE 344. Reverse String
        //create temp var as we need to swap in same array
        //start at first and last index while start index is less than end index
        //insert start val in temp, insert last value in first place and value in temp to last place
        //increment start
        //decremnt end

        public void ReverseStringFun(char[] s)
        {


            int i = 0;
            int j = s.Length - 1;
            while (i <j)
            {
                char temp = s[i];
                s[i] = s[j];
                s[j] = temp;
                i++;
                j--;
            }
            //char[] s = new char[] { 'h', 'e', 'l', 'l', 'o' }; 

            //var result = s.Reverse();
            //return result;

        }
    }
}
