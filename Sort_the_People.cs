using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    internal class Sort_the_People
    {
        public string[] SortPeople(string[] names, int[] heights)
        {
            int tempHeight = 0;
            string tempNames = "";
            int length = heights.Length;
            bool swapped;
            for (int i=0; i<length; i++)
            {
                swapped = false;
                for(int j=0; j<length-i-1; j++)
                {
               
                    if (heights[j]<heights[j+1])
                    {
                        tempHeight = heights[j];
                        tempNames = names[j];
                        heights[j] = heights[j+1];
                        names[j] = names[j+1];
                        heights[j+1] = tempHeight;
                        names[j+1] = tempNames;
                        swapped = true;
                    }
                }
                if (!swapped)
                    break;
            }

            return names;

        }
    }
}
