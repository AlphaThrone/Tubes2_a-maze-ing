namespace amazeing
{
    abstract class Algorithm
    {
        // === ATTRIBUTES ======================================================================
        private int id;
        private string name;
        private string fullName;
        private string desc;

        // === CONSTRUCTOR =====================================================================
        public Algorithm()
        {
            this.id = -1;
            this.name = "";
            this.fullName = "";
            this.desc = "";
        }

        public Algorithm(string name)
        {
            this.name = name;
            this.fullName = "";
            this.desc = "";

            if (name == "BFS")
            {
                this.id = 0;
                this.fullName = "Breadth First Search";
                this.desc = "Depth-first search starts a graph's traversal at an arbitrary vertex by marking it as visited. On each iteration, the algorithm proceeds to an unvisited vertex that is adjacent to the on it is currently in.";
            }
            else if (name == "DFS")
            {
                this.id = 1;
                this.fullName = "Depth First Search";
                this.desc = "Breadth-first search proceeds in a concentric manner by visitting first all the vertices that are adjacent to a starting vertex, then all unvisited vertices two edges apart from it, and so on, untill all the vertices in the same connected component as the starting vertex are visited.";
            }
        }

        // === METHODS =========================================================================
        public abstract Solution use(Node currentNode, Solution prevSolution, string currentStep);
    }
}