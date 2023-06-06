using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BFS
{
    public class Minimum_Depth_of_Binary_Tree
    {
        public int MinDepth(TreeNode root)
        {
            if(root == null)
                return 0; 

            int minPath = 1;
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                int levelSize = queue.Count;

                minPath++;
                for (int i=0; i<levelSize; i++)
                {
                    TreeNode currentNode = queue.Dequeue();
                    if (currentNode.left != null)
                        queue.Enqueue(currentNode.left);

                    if (currentNode.right != null)
                        queue.Enqueue(currentNode.right);
                    if (currentNode.right == null && currentNode.left == null)
                        return 1;
                }
            }
            return minPath;
        }
    }
}
