using AlgorithmFile;
using SolutionFile;
using NodeFile;

namespace DFSFile
{
    class DFS : Algorithm
    {
        // === ATTRIBUTES ======================================================================
        private Node?[] nodeStack;

        // === CONSTRUCTOR =====================================================================
        public DFS() : base("DFS")
        {
            this.nodeStack = new Node[100];
        }

        // === METHODS =========================================================================
        public void push(Node newNode)
        {
            for (int i = 0; i < 100; i++)
            {
                if (this.nodeStack[i] == null)
                {
                    this.nodeStack[i] = newNode;
                    break;
                }
            }
        }

        public void pop()
        {
            for (int i = 0; i < 100; i++)
            {
                if (this.nodeStack[i] == null)
                {
                    this.nodeStack[i - 1] = null;
                    break;
                }
            }
        }

        public Node getTop()
        {
            for (int i = 0; i < 100; i++)
            {
                if (this.nodeStack[i] == null)
                {
                    return this.nodeStack[i - 1];
                }
            }
            return null;
        }

        public override Solution use(Solution solution)
        {
            Solution newSolution = solution;
            this.nodeStack = new Node[newSolution.getMaze().getMazeDepth() * newSolution.getMaze().getMazeWidth()];

            push(newSolution.getMaze().getStartingNode());

            while (true)
            {
                Node currentNode = getTop();
                newSolution.getRoute().addNodeToRoute(getTop());

                if (currentNode.getStatus() != "Visited")
                {
                    newSolution.setVisitedNode(newSolution.getVisitedNode() + 1);
                }
                if (currentNode.getType() == "Treasure" && currentNode.getStatus() != "Visited")
                {
                    newSolution.setTreasureFound(newSolution.getTreasureFound() + 1);
                    Console.WriteLine("TREASURE FOUND: " + newSolution.getTreasureFound() + " id: " + currentNode.getPosX() + "," + currentNode.getPosY());

                    if (newSolution.getTreasureFound() == newSolution.getMaze().getNTreasure())
                    {
                        break;
                    }
                }

                currentNode.setStatus("Checking");

                if (currentNode.getLeftNode() != null && currentNode.getLeftNode().getStatus() == "Not visited")
                {
                    push(currentNode.getLeftNode());
                }
                else if (currentNode.getTopNode() != null && currentNode.getTopNode().getStatus() == "Not visited")
                {
                    push(currentNode.getTopNode());
                }
                else if (currentNode.getRightNode() != null && currentNode.getRightNode().getStatus() == "Not visited")
                {
                    push(currentNode.getRightNode());
                }
                else if (currentNode.getBottomNode() != null && currentNode.getBottomNode().getStatus() == "Not visited")
                {
                    push(currentNode.getBottomNode());
                }
                else
                {
                    bool isKeepTrack = false;
                    while (!getTop().isExplorable())
                    {
                        if (getTop().getType() != "Treasure" && !isKeepTrack)
                        {
                            pop();
                            solution.getRoute().removeNodeFromRoute();
                        }
                        else
                        {
                            pop();
                            isKeepTrack = true;
                            solution.getRoute().addNodeToRoute(getTop());
                        }
                    }
                }

                currentNode.setStatus("Visited");
            }
            return newSolution;
        }
    }
}
