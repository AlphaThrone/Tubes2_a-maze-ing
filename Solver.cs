using SolutionFile;
using MazeFile;
using AlgorithmFile;
using DFSFile;
using BFSFile;
using System.Diagnostics;

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

        // === METHODS =========================================================================
        public Solution solve(int id, Maze maze)
        {
            Solution solution = new Solution(id, maze);

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            solution = this.algorithms[id].use(solution);
            stopwatch.Stop();
            solution.setExecTime(stopwatch.ElapsedMilliseconds);
            solution.getRoute().initializeStep();

            return solution;
        }
    }

}