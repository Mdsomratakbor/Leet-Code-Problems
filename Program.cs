using System;

namespace LeetCodeProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Sum_of_Square_Numbers data = new();
            while (true)
            {
              var input =  Console.ReadLine();
                Console.WriteLine(data.JudgeSquareSum(Convert.ToInt32(input)));
            }
          
        }
    }
}
