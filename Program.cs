using System;

namespace LeetCodeProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Sqrt data = new();
            while (true)
            {
              var input =  Console.ReadLine();
                Console.WriteLine(data.MySqrt(Convert.ToInt32(input)));
            }
          
        }
    }
}
