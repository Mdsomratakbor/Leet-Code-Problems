using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Array_Problems.Easy
{
    internal class Pascal_s_Triangle
    {
        public IList<IList<int>> Generate(int numRows)
        {
            IList<IList<int>> results = new List<IList<int>>();
            for(int i=0; i<numRows; i++)
            {
                IList<int> list= new List<int>(Enumerable.Repeat(1, i+1));
                for(int j=1; j<i; j++)
                {
                    list[j] = (results[i - 1][j]+ results[i - 1][j-1]);
                }
                results.Add(list);
            }
            return results;
        }
    }
}
