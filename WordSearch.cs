using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class WordSearch
    {


        class pair
        {
            public int first, second;

            public pair(int first, int second)
            {
                this.first = first;
                this.second = second;
            }
        }
        static readonly int ROW = 4;
        static readonly int COL = 4;

        // Direction vectors
        int[] dRow = { -1, 0, 1, 0 };
        int[] dCol = { 0, 1, 0, -1 };

        // Function to check if a cell
        // is be visited or not
        public bool isValid(bool[,] vis,
                            int row, int col)
        {

            // If cell lies out of bounds
            if (row < 0 || col < 0 ||
                row >= ROW || col >= COL)
                return false;

            // If cell is already visited
            if (vis[row, col])
                return false;

            // Otherwise
            return true;
        }

        // Function to perform the BFS traversal
        public void BFS(char[,] grid, bool[,] vis,
                        int row, int col)
        {

            // Stores indices of the matrix cells
            Queue<pair> q = new Queue<pair>();

            // Mark the starting cell as visited
            // and push it into the queue
            q.Enqueue(new pair(row, col));
            vis[row, col] = true;

            // Iterate while the queue
            // is not empty
            while (q.Count != 0)
            {
                pair cell = q.Peek();
                int x = cell.first;
                int y = cell.second;
                Console.Write(grid[x, y] + " ");
                q.Dequeue();

                // Go to the adjacent cells
                for (int i = 0; i < 4; i++)
                {
                    int adjx = x + dRow[i];
                    int adjy = y + dCol[i];
                    if (isValid(vis, adjx, adjy))
                    {
                        q.Enqueue(new pair(adjx, adjy));
                        vis[adjx, adjy] = true;
                    }
                }
            }
        }
    }
}
