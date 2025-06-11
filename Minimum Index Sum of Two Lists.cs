using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class Minimum_Index_Sum_of_Two_Lists
    {
        public string[] FindRestaurant(string[] list1, string[] list2)
        {
            List<string> result = new List<string>();
            int minimumIndex =  int.MaxValue;
            int sum = 0;
            for(int i=0; i<list1.Length; i++)
            {
                for (int j=0; j<list2.Length; j++)
                {
                    if (list1[i] == list2[j])
                    {
                         sum = i + j;
                        if(minimumIndex<= sum)
                        {
                            minimumIndex = sum;
                            result.Add(list1[i]);
                        }
                    }
                }
            }

            return result.ToArray();

        }
    }
}
