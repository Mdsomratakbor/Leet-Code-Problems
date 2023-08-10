using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class Find_Common_Characters
    {
        public IList<string> CommonChars(string[] words)
        {
            IList<string> result = new List<string>();

           Dictionary<char, int> finalCount = new Dictionary<char, int>();

            for (char c = 'a'; c <= 'z'; ++c)
                finalCount[c] = 100;


            Dictionary<char, int> count = new Dictionary<char, int>();

            foreach (var word in words)
            {
                count.Clear();
                foreach (char c in word)
                {
                    if (count.ContainsKey(c))
                        count[c]++;
                    else
                        count.Add(c, 1);
                }

                for (char c = 'a'; c <= 'z'; ++c)
                    finalCount[c] = Math.Min(finalCount[c], count.GetValueOrDefault(c, 0));

            }
            for (char c = 'a'; c <= 'z'; ++c)
            {
                int tinmes = finalCount[c];
                while (tinmes > 0)
                {
                    result.Add(c.ToString());
                    tinmes--;
                }
            }
            return result;

        }
    }
}
