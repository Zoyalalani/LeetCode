using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms
{
    public class RemoveAnagrams
    {
        public IList<string> RemoveAnagramsFunc(string[] words)
        {
            //2273. Find Resultant Array After Removing Anagrams
            // convert words to characters, order them by asc so all words are arranged in same orders, convert back to strings
            //Group same words together
            //get first of groups


            //words = ["abba","baba","bbaa","cd","cd"]
            //["abba","cd"]
            List<string> resultArray = new List<string>();

            var group = words.GroupBy(word =>  new string(word.ToCharArray().OrderBy(c=>c).ToArray()));


            foreach (var a in group)
            {
                resultArray.Add(a.First());
            }

            return resultArray.ToList();

        }
    }
}
