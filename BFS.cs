using AlgorithmFile;
using System;
using NodeFile;
using SolutionFile;

namespace BFSFile
{
    class BFS : Algorithm
    {
        // === CONSTRUCTOR =====================================================================
        public BFS() : base("BFS") { }

        // === METHODS =========================================================================
        public override Solution use(Node currentNode, Solution prevSolution, string currentStep)
        {
            Solution solution = prevSolution;

            return solution;
        }
    }
}