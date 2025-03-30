using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeProblems{

    public class MaximumOddBinaryNumber
    {
           public string MaximumOddBinaryNumber(string s) {

                int countOne = s.Count(c => c == '1');

               int countZero = s.Length - countOne;

                return new string('1', countOne - 1) + new string('0', countZero) + '1';;
        
            }
            public string MaximumOddBinaryNumberOld(string s) {

                int countOne = s.Count(c => c == '1');

                StringBuilder newBinary = new StringBuilder();

                for(int i =0; i< countOne - 1; i++){
                    newBinary.Append('1');
                }
                for(int i=0; i< s.Length - countOne ; i++){
                    newBinary.Append('0');
                }
                newBinary.Append('1');

                return newBinary.ToString();
        
            }
    }
}