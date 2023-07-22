using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class String_Matching_in_an_Array
    {
        public IList<string> StringMatching(string[] words)
        {
            IList<string> result = new List<string>();
            for (int j = 0; j<words.Length; j++)
            {

                for(int i=j+1; i<words.Length-1; i++)
                {
                    if (words[i].Contains(words[j]))
                    {
                        result.Add(words[j]);
                    }
                    if (words[j].Contains(words[i]))
                    {
                        result.Add(words[i]);

                    }
                }
            }
            result = result.Distinct().ToList();
            return result;

        }
    }
}
