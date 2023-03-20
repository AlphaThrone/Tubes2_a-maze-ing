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
        private int visitedNode;
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
            this.visitedNode = 0;
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

        public void setVisitedNode(int visitedNode)
        {
            this.visitedNode = visitedNode;
        }

        public int getVisitedNode()
        {
            return this.visitedNode;
        }
    }
}