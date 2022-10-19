using System;

namespace LeetCodeProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Power_of_xn data = new();
            while (true)
            {
              var input =  Console.ReadLine();
                Console.WriteLine(data.MyPow(2.00000, -2));
            }
          
        }
    }
}
