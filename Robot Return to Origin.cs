using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class Robot_Return_to_Origin
    {
    public bool JudgeCircle(string moves) {
    int vertical = 0, horizontal = 0;

    foreach (char move in moves) {
        switch(move){
            case 'U': vertical++; break;
            case 'D': vertical--; break;
            case 'L': horizontal--; break;
            case 'R': horizontal++; break;
        }
    }

    return vertical == 0 && horizontal == 0;
}
        
    }
}