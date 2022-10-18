using System;

namespace LeetCodeProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            ValidPerfectSquare data= new();
            while (true)
            {
              var input =  Console.ReadLine();
                Console.WriteLine(data.IsPerfectSquare(Convert.ToInt32(input)));
            }
          
        }
    }
}
