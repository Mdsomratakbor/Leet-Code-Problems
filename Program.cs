using System;

namespace LeetCodeProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            SortColor data = new();
            while (true)
            {
                var input = Console.ReadLine().Split(' ');
                int[] array =  new int[] { 2, 0, 2, 1, 1, 0};
                data.SortColors(array);
            }
          
        }
    }
}
