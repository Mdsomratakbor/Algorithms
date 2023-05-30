using BFS;

//Graph graph = new Graph(4);
//graph.AddEdge(0,1);
//graph.AddEdge(0,2);
//graph.AddEdge(0,3);
//graph.AddEdge(1,2);
//graph.AddEdge(3,3);
//graph.AddEdge(2,3);

//graph.BFS(0);

TreeNode root = new TreeNode(3);
root.left = new TreeNode(9);
root.right = new TreeNode(20);
root.right.left = new TreeNode(15);
root.right.right = new TreeNode(7);

Binary_Tree_Level_Order_Traversal binaryTree = new ();
IList<IList<int>> traversalResult = binaryTree.LevelOrder(root);