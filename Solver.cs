using SolutionFile;
using MazeFile;
using AlgorithmFile;
using DFSFile;
using BFSFile;

namespace SolverFile
{
    class Solver
    {
        // === ATTRIBUTES ======================================================================
        private Algorithm[] algorithms;

        // === CONSTRUCTOR =====================================================================
        public Solver()
        {
            this.algorithms = new Algorithm[2];
            this.algorithms[0] = new BFS();
            this.algorithms[1] = new DFS();
        }

        public Solution solve(int id, Maze maze)
        {
            Solution solution = new Solution(id, maze);

            solution = this.algorithms[id].use(solution);
            solution.getRoute().initializeStep();

            return solution;
        }
    }

}