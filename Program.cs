using System;

namespace LeetCodeProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Interview_problem_06 data = new();
            while (true)
            {
                var input = Console.ReadLine().Split(' ');
                data.printMinimumValue(input);
            }
          
        }
    }
}
