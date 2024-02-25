using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Math_Problems.Medium
{
    public class RectangleArea
    {
        public int ComputeArea(
            int ax1, int ay1, 
            int ax2, int ay2,
            int bx1, int by1, 
            int bx2, int by2)
        {
            int areaOfRectangleOne = Math.Abs(ax1-ax2) * Math.Abs(ay1-ay2); // Menhattan Distace
            int areaOfRectangleTwo = Math.Abs(bx1-bx2) * Math.Abs(by1-by2);

            int x_distance = Math.Min(ax2, bx2) - Math.Max(ax1, bx1);
            int y_distance = Math.Min(ay2, by2) - Math.Max(ay1, by1);
            int areaI = 0;
            if (x_distance > 0 && y_distance > 0)
            {
                areaI = x_distance * y_distance;
            }
            return areaOfRectangleOne + areaOfRectangleTwo - areaI;
        }
    }
}
