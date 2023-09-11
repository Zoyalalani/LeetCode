using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms
{
    public class StringMatchingInArray
    {
        //LEETCODE : 1408. String Matching in an Array

        public IList<string> StringMatching(string[] words)
        {
            //words = ["mass", "as", "hero", "superhero"]  //y
            //output = ["as","hero"]  //x

            var firstQuery = words.Where(word => (words.Any(w => w!= word && w.Contains(word)))).ToList();

            var secondQuery = from x in words
                        from y in words
                        where y.Contains(x)
                        where y != x
                        select x;

            return firstQuery.ToList();
        }
    }
}
