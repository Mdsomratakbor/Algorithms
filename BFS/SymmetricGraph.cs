using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BFS
{
    public class SymmetricGraph
    {
        public bool IsSymmetricGraph(TreeNode root)
        {
            List <List<int>> data = new List <List<int>>();
            if (root == null) 
            {
                return true;
            }
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            queue.Enqueue(root);
            data.Add(new List<int> { root.val });
            while (queue.Count > 0)
            {
                TreeNode node1 = queue.Dequeue();
                TreeNode node2 = queue.Dequeue();
                if (node1 == null && node2 == null)
                    continue;
                if (node1 == null || node2 == null || node1.val != node2.val)
                    return false;
                queue.Enqueue(node1.left);
                queue.Enqueue(node2.right);
                queue.Enqueue(node1.right);
                queue.Enqueue(node2.left);
            }
            return true;

        }
    }
}
