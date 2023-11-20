using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Array_Problems.Easy
{
    internal class Pascal_s_Triangle_II
    {
        // Using O(K) space solve this problem

        public IList<int> GetRow(int rowIndex)
        {
            rowIndex += 1;

            IList<int> list = new List<int>(Enumerable.Repeat(1, rowIndex));

            for (int i = 2; i < rowIndex; i++)
            {
                for (int j = i - 1; j >= 1; j--)
                {
                    list[j] += list[j - 1];
                }
            }
            return list;
        }

        public IList<int> GetRow_Old(int rowIndex)
        {
            rowIndex += 1;
            IList<IList<int>> results = new List<IList<int>>();
            for (int i = 0; i < rowIndex; i++)
            {
                IList<int> list = new List<int>(Enumerable.Repeat(1, i + 1));
                for (int j = 1; j < i; j++)
                {
                    list[j] = (results[i - 1][j] + results[i - 1][j - 1]);
                }
                results.Add(list);
            }
            return results.ElementAt(rowIndex-1);
        }
    }
}
