using LeetCodeProblems.Array_Problems.Medium;
using System;

namespace LeetCodeProblems
{
    class Program
    {
        static void Main(string[] args)
        {

            Merge_Strings_Alternately nameOfClass = new();

            //            TreeNode root = new TreeNode(2);
            //            root.right = new TreeNode(3);
            //            root.left = new TreeNode(4);
            //            root.right.right = new TreeNode(4);
            //            root.right.right.right = new TreeNode(5);
            //            root.right.right.right.right = new TreeNode(6);

            //            //  IList<IList<string>> matrix = new List<IList<string>>();
            //            // matrix.Add(new List<string>() { "cat", "bat", "rat" });
            //            // matrix.Add(new List<string>() { "kzwEQHfwce", "pYyNGfBYbm" });
            //            //matrix.Add(new List<string>() { "Lima", "Sao Paulo" });

            //            // IList<string> matrix = new List<string>() { "cat", "bat", "rat" };
            //            //string sen= "the cattle was rattled by the battery";
            //            //Console.WriteLine(data.IsValid("ab", new string[] { "ad", "bd", "aaab", "baa", "badab" }));

            //            int[] array1 = { 1, 2, 3, 0, 0, 0 };
            //            int[] array2 = { 2, 5, 6 };++++++++++++++++++++++++++++++++++
            //            int[,] twoDimensionalArray = new int[,]
            //{
            //    { 0, 2 },
            //    { 1, 4 },
            //    { 1, 1 }
            //};
            //            int[][] jaggedArray = new int[][]
            //{
            //    new int[] { 0, 2 },
            //    new int[] { 1, 4 },
            //    new int[] { 1, 1 }
            //};

            // 000, 111, 99
            // 
            //   var data = new int[] {  1, 1, 0, 1, 99,99,99 };
            //var data2 = nameOfClass.SingleNumber(data);
            var data2 = nameOfClass.MergeAlternately("ab", "pqrs");

            Console.WriteLine(data2);



        }
    }
}
