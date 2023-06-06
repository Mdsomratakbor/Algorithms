import heapq


class Node:
    def __init__(self, position, parent=None, g=0, h=0):
        self.position = position
        self.parent = parent
        self.g = g
        self.h = h

    def f(self):
        return self.g + self.h

    def __lt__(self, other):
        return self.f() < other.f()

    def __gt__(self, other):
        return self.f() > other.f()

    def __le__(self, other):
        return self.f() <= other.f()

    def __ge__(self, other):
        return self.f() >= other.f()


def get_path(node):
    path = []
    current = node
    while current is not None:
        path.append(current.position)
        current = current.parent
    path.reverse()
    return path


def get_neighbors(grid, position):
    neighbors = []
    row, col = position
    moves = [("up", (row - 1, col), 4),
             ("down", (row + 1, col), 1),
             ("left", (row, col - 1), 2),
             ("right", (row, col + 1), 3)]

    for move, (new_row, new_col), cost in moves:
        if 0 <= new_row < len(grid) and 0 <= new_col < len(grid[0]):
            if grid[new_row][new_col] != 1:  # Check for obstacles (1 represents obstacles)
                neighbors.append(((new_row, new_col), cost))
    return neighbors


def heuristic(position, goal):
    return abs(position[0] - goal[0]) + abs(position[1] - goal[1])


def a_star_search(grid, start, goal):
    open_list = []
    closed_set = set()
    heapq.heappush(open_list, (0, Node(start)))

    while open_list:
        _, current_node = heapq.heappop(open_list)
        current_position = current_node.position

        if current_position == goal:
            return get_path(current_node)

        closed_set.add(current_position)

        for neighbor_position, move_cost in get_neighbors(grid, current_position):
            if neighbor_position in closed_set:
                continue

            g = current_node.g + move_cost
            h = heuristic(neighbor_position, goal)
            neighbor_node = Node(neighbor_position, current_node, g, h)
            heapq.heappush(open_list, (neighbor_node.f(), neighbor_node))

    return None


# Example usage
grid = [[0, 0, 0, 0],
        [0, 1, 0, 1],
        [0, 0, 0, 0],
        [0, 0, 0, 0]]

start_position = (0, 0)
goal_position = (3, 3)

path = a_star_search(grid, start_position, goal_position)

if path is not None:
    print("Path found:")
    for position in path:
        print(position)
else:
    print("No path found.")