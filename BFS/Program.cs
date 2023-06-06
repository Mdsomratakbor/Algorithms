using BFS;

//Graph graph = new Graph(4);
//graph.AddEdge(0,1);
//graph.AddEdge(0,2);
//graph.AddEdge(0,3);
//graph.AddEdge(1,2);
//graph.AddEdge(3,3);
//graph.AddEdge(2,3);

//graph.BFS(0);

TreeNode root = new TreeNode(2);
root.right = new TreeNode(3);
root.right.right = new TreeNode(4);
root.right.right.right = new TreeNode(5);
root.right.right.right.right = new TreeNode(6);

Minimum_Depth_of_Binary_Tree binaryTree = new ();
//IList<IList<int>> traversalResult = Maximum_Depth_of_Binary_Tree.MaxDepth(root);
int traversalResult = binaryTree.MinDepth(root);
Console.WriteLine(traversalResult);