using System;

namespace LeetCodeProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            RotateArray data = new();
            while (true)
            {
                var input = Console.ReadLine().Split(' ');
                int[] aray = {-1};
                data.Rotate(aray, 2);
            }
          
        }
    }
}
