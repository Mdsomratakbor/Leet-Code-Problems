using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class goal_parser_interpretation
    {
         public string Interpret(string command) {
            StringBuilder result = new StringBuilder();
            int i =0;
            while(i<command.Length){
                if(command[i] == 'G')
                    {
                        result.Append("G");
                        i++;
                    }
                else if(command[i] == '('){
                    if(command[i+1] == ')'){
                        result.Append("o");
                        i+=2;
                    }
                    else if(command[i+1] == 'a'){
                        result.Append("al");
                        i+= 4;
                    }
                }
                return result.ToString();
            }
        }
    }
}