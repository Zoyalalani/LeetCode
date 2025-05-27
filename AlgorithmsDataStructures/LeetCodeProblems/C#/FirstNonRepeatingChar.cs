using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms
{
    public class FirstNonRepeatingChar
    {
        public int FirstUniqChar(string s)
        {
            char[] charArray = s.ToCharArray();
            char result = ' ';

            var data = charArray.GroupBy(x => x);
            if (data.Any())
            {
                result = data.First(y => y.Count() == 1).Key;
            }

            if (result == ' ')
            {
                return -1;
            }
            return Array.IndexOf(charArray, result);

        }
    }
}
