import networkx as nx
import matplotlib.pyplot as plt

class Graph:
    def __init__(self, vertices):
        self.V = vertices
        self.graph = [[0 for column in range(vertices)] 
                      for row in range(vertices)]
  
    def is_safe(self, v, color, c):
        for i in range(self.V):
            if self.graph[v][i] == 1 and color[i] == c:
                return False
        return True
  
    def graph_color_util(self, m, color, v):
        if v == self.V:
            return True
        for c in range(1, m+1):
            if self.is_safe(v, color, c) == True:
                color[v] = c
                if self.graph_color_util(m, color, v+1) == True:
                    return True
                color[v] = 0
  
    def graph_coloring(self, m):
        color = [0] * self.V
        if self.graph_color_util(m, color, 0) == None:
            print("Solution does not exist")
            return False
        
        print("Solution exists and the colors are:")
        # Create the graph using the networkx library
        G = nx.Graph()
        G.add_nodes_from(list(range(1, self.V+1)))
        for i in range(self.V):
            for j in range(self.V):
                if self.graph[i][j] == 1:
                    G.add_edge(i+1, j+1)
        
        # Define the colors for the nodes
        colors = ['black', 'orange', 'gray']
        node_colors = [colors[color[i]-1] for i in range(self.V)]
        
        # Draw the graph with the specified colors
        nx.draw(G, node_color=node_colors, with_labels=True)
        
        # Show the plot
        plt.show()
        
        return True

# Driver Code
g = Graph(4)
g.graph = [[0, 1, 1, 1],
           [1, 0, 1, 0],
           [1, 1, 0, 1],
           [1, 0, 1, 0]]
m = 3
g.graph_coloring(m)