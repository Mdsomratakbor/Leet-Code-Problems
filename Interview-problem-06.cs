using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    internal class Interview_problem_06
    {
        
        public void printMinimumValue(string[] value)
        {
            int n1 = Convert.ToInt32(value[0]), n2 = Convert.ToInt32(value[1]), n3 = Convert.ToInt32(value[2]), min=0;
            if (n1 < n2)
            {
                min = n1;
            }
            else{
                min = n2;
            }
            if (n3 < min)
            {
                min=n3;
            }


            Console.WriteLine("Minimum value is:"+ min);
        }
    }

}
