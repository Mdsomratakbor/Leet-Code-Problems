using System;
using System.Collections.Generic;

namespace LeetCodeProblems
{
    class Program
    {
        static void Main(string[] args)
        {

            Check_if_Numbers_Are_Ascending_in_a_Sentence data = new();


            //  IList<IList<string>> matrix = new List<IList<string>>();
            // matrix.Add(new List<string>() { "cat", "bat", "rat" });
            // matrix.Add(new List<string>() { "kzwEQHfwce", "pYyNGfBYbm" });
            //matrix.Add(new List<string>() { "Lima", "Sao Paulo" });

            // IList<string> matrix = new List<string>() { "cat", "bat", "rat" };
            //string sen= "the cattle was rattled by the battery";
            //Console.WriteLine(data.IsValid("ab", new string[] { "ad", "bd", "aaab", "baa", "badab" }));

            int[] array1 = { 1, 2, 3, 0, 0, 0 };  
            int[] array2 = { 2, 5, 6 };  
            var data2 =data.AreNumbersAscending("1 box has 3 blue 4 red 6 green and 12 yellow marbles");
    Console.WriteLine(data2);

          

        }
    }
}
