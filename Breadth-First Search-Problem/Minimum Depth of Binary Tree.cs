using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Breadth_First_Search_Problem
{
   
    public class Minimum_Depth_of_Binary_Tree
    {
        public int MinDepth(TreeNode root)
        {
            if(root==null)
                return 0;
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            int depth = 1;
            while(queue.Count >0)
            {
                int size = queue.Count;
                while(size-->0) {
                    root = queue.Dequeue();
                    if(root.left==null && root.right ==null )
                        return depth;
                    if(root.left != null)
                        queue.Enqueue(root.left);
                    if(root.right != null)
                        queue.Enqueue(root.right);
                }
                depth++;
            }
            return depth;

        }
    }
}
