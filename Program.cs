using System;

namespace LeetCodeProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Strong_Password_Checker_II data = new();
            // while (true)
            //   {
            // var input = Console.ReadLine().Split(' ');
            // Given array
            char[,] grid = { { 'A','B','C','E' },
                   { 'S','F','C','S' },
                   {  'A','D','E','E'},
            {  'A','D','E','E'}};
            int ROW = 4;
            int COL = 4;
            // Declare the visited array
            bool[,] vis = new bool[ROW, COL];
         
            // path from arr[0][0]
            // to arr[row][col]
            Console.WriteLine(data.StrongPasswordCheckerII("-Aa1a1a1"));
          //var lists=  data.Permute(new int[] { 1, 2, 3 });
            //Console.WriteLine("[");
            //foreach (var list in lists)
            //{
            //    Console.WriteLine($"    [{string.Join(',', list)}]");
            //}
            //Console.WriteLine("]");
            //if (data.BFS(grid, vis, 0, 0))
            //   Console.WriteLine("Yes");
            // else
            //  Console.WriteLine("No");
            // }

        }
    }
}
