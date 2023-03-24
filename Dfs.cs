using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazeing
{
    public class Dfs : Algorithm
    {
        // === ATTRIBUTES ======================================================================
        private Node[] nodeStack;

        // === CONSTRUCTOR =====================================================================
        public Dfs() : base("DFS") { }

        // === METHODS =========================================================================
        public void Push(Node newNode)
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

        public void Pop()
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

        public Node GetTop()
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

        public override Solution Use(Solution solution)
        {
            Solution newSolution = solution;

            // 1. Initialize stack
            this.nodeStack = new Node[newSolution.Maze.Depth * newSolution.Maze.Width];
            Push(newSolution.Maze.StartingNode);

            // 2. Iteration
            while (true)
            {
                // 2.1. Initialize current node
                Node currentNode = GetTop();
                // Console.WriteLine(GetTop().Id + " ( " + GetTop().X + "," + GetTop().Y + " )");
                newSolution.Route.AddNodeToRoute(GetTop());
                newSolution.Route.AddNodeToSelectedRoute(GetTop());

                // 2.2. Check if current node is visited
                if (currentNode.Status != "Visited")
                {
                    newSolution.VisitedNode++;
                }

                // 2.3. Check if current node is a not collected treasure
                if (currentNode.Type == "Treasure" && currentNode.Status != "Visited")
                {
                    newSolution.TreasureFound++;
                    Console.WriteLine(GetTop().Id + " ( " + GetTop().X + "," + GetTop().Y + " )");

                    if (newSolution.TreasureFound == newSolution.Maze.NTreasure)
                    {
                        break;
                    }
                }

                // 2.4 Update current node state
                currentNode.Status = "Checking";

                // 2.5 Push adjacent node to stack
                if (currentNode.Left != null && currentNode.Left.Status == "Not visited")
                {
                    Push(currentNode.Left);
                }
                else if (currentNode.Top != null && currentNode.Top.Status == "Not visited")
                {
                    Push(currentNode.Top);
                }
                else if (currentNode.Right != null && currentNode.Right.Status == "Not visited")
                {
                    Push(currentNode.Right);
                }
                else if (currentNode.Bottom != null && currentNode.Bottom.Status == "Not visited")
                {
                    Push(currentNode.Bottom);
                }

                // 2.6 If current node is a dead end
                else
                {
                    
                    bool isKeepTrack = false;
                    while (!GetTop().IsExplorable())
                    {
                        if (GetTop().Type != "Treasure" && !isKeepTrack)
                        {
                            Pop();
                            newSolution.Route.RemoveNodeFromSelectedRoute();
                        }
                        else
                        {
                            isKeepTrack = true;
                            Pop();
                            newSolution.Route.AddNodeToSelectedRoute(GetTop());
                        }
                        // newSolution.Route.AddNodeToRoute(GetTop());
                    }
                    
                }

                // 2.7 Update current node state
                currentNode.Status = "Visited";
            }

            // 3. Initialize steps
            newSolution.Route.InitializeStep();
            Console.WriteLine(newSolution.Route.RouteStr);

            return newSolution;
        }
    }
}
