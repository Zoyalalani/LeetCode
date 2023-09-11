using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms
{

    //345. Reverse Vowels of a String
    //Same like last time us e while to traverse between front and back
    //if no vowels found in left, continue.
    //if no vowels found in right, continue
    //else swap using temp
    public class ReverseVowelsInString
    {
        public string ReverseVowels(string s)
        {
            List<char> res = s.ToList();
            int l, r;
            l = 0; r = s.Length - 1;

            while (l < r)
            {
                if (!"aeiouAEIOU".Contains(res[l]))
                {
                    l++; continue;
                }

                if (!"aeiouAEIOU".Contains(res[r]))
                {
                    r--; continue;
                }

                char temp = res[l];
                res[l] = res[r];
                res[r] = temp;

                l++; r--;
            }

            return String.Join("", res);
        }
    }
}
