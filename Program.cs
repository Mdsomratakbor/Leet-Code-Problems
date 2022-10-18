using System;

namespace LeetCodeProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Roman_to_Integer data = new();
            while (true)
            {
              var input =  Console.ReadLine();
                Console.WriteLine(data.RomanToInt(input));
            }
          
        }
    }
}
