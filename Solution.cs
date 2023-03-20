using MazeFile;
using RouteFile;

namespace SolutionFile
{
    class Solution
    {
        // === ATTRIBUTES ======================================================================
        private Maze maze;
        private string algorithm;
        private int execTime;
        // private Node[] visitedNode;
        private Route route;
        private int treasureFound;

        // === CONSTRUCTOR =====================================================================
        public Solution(int id, Maze maze)
        {
            this.maze = maze;

            if (id == 0)
            {
                this.algorithm = "BFS";
            }
            else
            {
                this.algorithm = "DFS";
            }

            this.execTime = 0;
            // this.visitedNode = new Node[100];
            this.route = new Route();
            this.treasureFound = 0;
        }

        // === GETTER SETTER ===================================================================
        public Maze getMaze()
        {
            return this.maze;
        }

        public string getAlgorithmName()
        {
            return this.algorithm;
        }

        public void setTreasureFound(int nTreasure)
        {
            this.treasureFound = nTreasure;
        }

        public int getTreasureFound()
        {
            return this.treasureFound;
        }

        public Route getRoute()
        {
            return this.route;
        }

        public int getVisitedNode()
        {
            int ret = 0;

            for (int i = 0; i < maze.getMazeDepth(); i++)
            {
                for (int j = 0; j < maze.getMazeWidth(); j++)
                {
                    if (this.maze.getMatrix()[i, j] != null)
                    {
                        if (this.maze.getMatrix()[i, j].getStatus() == "Visited")
                        {
                            ret++;
                        }
                    }
                }
            }

            return ret;
        }
    }
}