using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms
{
    //989. Add to Array-Form of Integer
    //Come back to this again

    public class AddToArrayForm
    {
        //num = [1,2,0,0]
        //k = 181
        public IList<int> AddToArrayFormFunc(int[] num, int k)
        {
            List<int> list = new List<int>();
            int carry = k, i = num.Length - 1;

            while (i >= 0 || carry > 0)
            {
                int value = i >= 0 ? num[i] : 0;
                int sum = carry + value;
                carry = sum / 10;
                list.Add(sum % 10);
                i--;
            }
            list.Reverse();
            return list;


        }
    }
}
