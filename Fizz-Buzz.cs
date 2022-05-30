using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class Fizz_Buzz
    {
        public IList<string> FizzBuzz(int n)
        {
            return Enumerable.Range(1, n).Select(i => i % 3 == 0 && i % 5 == 0 ? "FizzBuzz" : i % 3 == 0 ? "Fizz" : i % 5 == 0 ? "Buzz" : i.ToString()).ToList();
        }
    }
}
