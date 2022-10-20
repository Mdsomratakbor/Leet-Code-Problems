using System;

namespace LeetCodeProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Divide_Two_Integers data = new();
            while (true)
            {
                var input = Console.ReadLine().Split(' ');
                Console.WriteLine(data.Divide(Convert.ToInt32(input[0]), Convert.ToInt32(input[1])));
            }
          
        }
    }
}
