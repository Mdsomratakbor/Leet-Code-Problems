using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class Split_Strings_by_Separator
    {
        public IList<string> SplitWordsBySeparator(IList<string> words, char separator)
        {
            IList<string> result = new List<string>();
            foreach (string word in words)
            {
                string[] split = word.Split(separator);
                if (split.Length >0)
                {
                   for(int i=0; i<split.Length; i++)
                    {
                        result.Add(split[i]);
                    }
                }
                else
                {
                    result.Add(word);
                }
                
            }
            return result;
        }
    
}
}
