using System;
using System.Collections.Generic;

namespace LeetCodeProblems
{
    class Program
    {
        static void Main(string[] args)
        {

            Number_of_Senior_Citizens data = new();


            //  IList<IList<string>> matrix = new List<IList<string>>();
            // matrix.Add(new List<string>() { "cat", "bat", "rat" });
            // matrix.Add(new List<string>() { "kzwEQHfwce", "pYyNGfBYbm" });
            //matrix.Add(new List<string>() { "Lima", "Sao Paulo" });

            // IList<string> matrix = new List<string>() { "cat", "bat", "rat" };
            //string sen= "the cattle was rattled by the battery";
            //Console.WriteLine(data.IsValid("ab", new string[] { "ad", "bd", "aaab", "baa", "badab" }));

            int[] array1 = { 1, 2, 3, 0, 0, 0 };  
            int[] array2 = { 2, 5, 6 };  
            var data2 =data.CountSeniors(new string[] {"7868190130M7522", "5303914400F9211", "9273338290F4010"});
    Console.WriteLine(data2);

          

        }
    }
}
