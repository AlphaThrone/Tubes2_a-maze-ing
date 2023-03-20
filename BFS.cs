using AlgorithmFile;
using System;
using NodeFile;
using SolutionFile;

namespace BFSFile
{
    class BFS : Algorithm
    {
        // === ATTRIBUTES ======================================================================
        private Node?[] queue;

        // === CONSTRUCTOR =====================================================================
        public BFS() : base("BFS")
        {
            queue = new Node[100];
        }

        // === METHODS =========================================================================
        public void enqueue(Node newNode)
        {
            for (int i = 0; i < 100; i++)
            {
                if (this.queue[i] == null)
                {
                    this.queue[i] = newNode;
                    break;
                }
            }
        }

        public void dequeue()
        {
            this.queue[0] = null;
            for (int i = 1; i < 100; i++)
            {
                this.queue[i - 1] = this.queue[i];

                if (this.queue[i] == null)
                {
                    break;
                }
            }
        }

        public override Solution use(Node currentNode, Solution prevSolution, string currentStep)
        {
            Solution solution = prevSolution;

            enqueue(currentNode);
            solution.setVisitedNode(1);

            while (solution.getTreasureFound() != solution.getMaze().getNTreasure())
            {
                // 1. Update node status
                this.queue[0].setStatus("Checking");
                solution.setVisitedNode(solution.getVisitedNode() + 1);

                // 2. Update route graph
                solution.getRoute().addNodeToRoute(this.queue[0]);

                // 3. Update treasure found
                if (this.queue[0].getType() == "Treasure")
                {
                    solution.setTreasureFound(solution.getTreasureFound() + 1);
                }

                // 4. Update node status
                this.queue[0].setStatus("Route");

                // 5. Enqueue left node if exists
                if (this.queue[0].getLeftNode() != null && this.queue[0].getLeftNode().getStatus() == "Not visited")
                {
                    enqueue(this.queue[0].getLeftNode());
                }

                // 6. Enqueue top node if exists
                if (this.queue[0].getTopNode() != null && this.queue[0].getTopNode().getStatus() == "Not visited")
                {
                    enqueue(this.queue[0].getTopNode());
                }

                // 7. Enqueue right node if exists
                if (this.queue[0].getRightNode() != null && this.queue[0].getRightNode().getStatus() == "Not visited")
                {
                    enqueue(this.queue[0].getRightNode());
                }

                // 8. Enqueue bottom node if exists
                if (this.queue[0].getBottomNode() != null && this.queue[0].getBottomNode().getStatus() == "Not visited")
                {
                    enqueue(this.queue[0].getBottomNode());
                }

                // 9. Dequeue
                dequeue();
            }

            return solution;
        }
    }
}