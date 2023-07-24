using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class Final_Value_of_Variable_After_Performing_Operations
    {
        public int FinalValueAfterOperations(string[] operations)
        {
            int sum = 0;
            foreach (var operation in operations)
            {
                if(operation.Equals("--X") || operation.Equals("X--"))
                {
                    sum -= 1;
                }
                else if(operation.Equals("++X") || operation.Equals("X++"))
                {
                    sum += 1;
                }
            }
            return sum;
        }
    }
}
