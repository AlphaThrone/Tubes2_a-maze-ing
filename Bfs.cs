using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazeing
{
    public class Bfs : Algorithm
    {
        // === ATTRIBUTES ======================================================================
        private Queue<Node> nodeQueue;

        // === CONSTRUCTOR =====================================================================
        public Bfs() : base("BFS") { }

        // === METHODS =========================================================================
        public override Solution Use(Solution solution)
        {
            this.nodeQueue = new Queue<Node>();
            Solution newSolution = solution;
            Node currentNode = newSolution.Maze.StartingNode;
            List<Node> treasureFound = new List<Node>();
            Console.WriteLine("In AllTreasure");
            List<Node> allTreasures = getAllTreasure(solution);
            Console.WriteLine("Out AllTreasure");

            this.nodeQueue.Enqueue(solution.Maze.StartingNode);
            while (true)
            {
                currentNode = this.nodeQueue.Dequeue();
                newSolution.Route.AddNodeToRoute(currentNode);
                if (currentNode.Status != "Visited")
                {
                    newSolution.VisitedNode++;
                }

                if (currentNode.Type == "Treasure" && currentNode.Status != "Visited" && !isAlreadyFound(currentNode, treasureFound))
                {
                    newSolution.TreasureFound++;
                    treasureFound.Add(currentNode);

                    // Console.WriteLine("TREASURE FOUND: " + newSolution.TreasureFound + " id: " + currentNode.X + "," + currentNode.Y);

                    searchPath(currentNode, newSolution);
                    resetPreviousNode(newSolution);
                    resetStatus(newSolution);
                    nodeQueue.Clear();

                    Console.WriteLine("In");
                    if (isAllTreasuresFound(treasureFound, allTreasures))
                    {
                        for (int i = 0; i < newSolution.Route.NSelectedRoute; i++)
                        {
                            if (newSolution.Route.SelectedRouteGraph[i] != null)
                            {
                                newSolution.Route.SelectedRouteGraph[i].Status = "Visited";
                                Console.WriteLine("Out");
                            }                            
                        }
                        break;
                    }
                    
                }
                search(newSolution, currentNode);
                currentNode.Status = "Visited";
            }

            newSolution.Route.InitializeStep();

            return newSolution;
        }

        public void search(Solution solution, Node currentNode)
        {
            currentNode.Status = "Checking";
            if (currentNode.Left != null && currentNode.Left.Status == "Not visited" && !nodeQueue.Contains(currentNode.Left))
            {
                currentNode.Left.Previous = currentNode;
                this.nodeQueue.Enqueue(currentNode.Left);
            }
            if (currentNode.Top != null && currentNode.Top.Status == "Not visited" && !nodeQueue.Contains(currentNode.Top))
            {
                currentNode.Top.Previous = currentNode;
                this.nodeQueue.Enqueue(currentNode.Top);
            }
            if (currentNode.Right != null && currentNode.Right.Status == "Not visited" && !nodeQueue.Contains(currentNode.Right))
            {
                currentNode.Right.Previous =currentNode;
                this.nodeQueue.Enqueue(currentNode.Right);

            }
            if (currentNode.Bottom != null && currentNode.Bottom.Status == "Not visited" && !nodeQueue.Contains(currentNode.Bottom))
            {
                currentNode.Bottom.Previous = currentNode;
                this.nodeQueue.Enqueue(currentNode.Bottom);

            }
        }

        public bool isAllTreasuresFound(List<Node> treasures, List<Node> allTreasures)
        {
            if (treasures.Count() == allTreasures.Count())
            {
                int count = 0;
                for (int j = 0; j < allTreasures.Count(); j++)
                {
                    if (treasures.Contains(allTreasures[j]))
                    {
                        count++;
                    }
                }
                return count == allTreasures.Count();
            }
            else
            {
                return false;
            }

        }

        public List<Node> getAllTreasure(Solution solution)
        {
            List<Node> allTreasures = new List<Node>();
            for (int i = 0; i < solution.Maze.Depth; i++)
            {
                for (int j = 0; j < solution.Maze.Width; j++)
                {
                    if(solution.Maze.NodeMatrix[i, j] != null)
                    {
                        if (solution.Maze.NodeMatrix[i, j].Type == "Treasure")
                        {
                            allTreasures.Add(solution.Maze.NodeMatrix[i, j]);
                        }
                    }
                }
            }
            return allTreasures;
        }

        public bool isAlreadyFound(Node treasure, List<Node> founded)
        {
            for (int i = 0; i < founded.Count(); i++)
            {
                if (treasure == founded[i])
                {
                    return true;
                }
            }
            return false;
        }

        public void resetStatus(Solution solution)
        {
            for (int i = 0; i < solution.Maze.Depth; i++)
            {
                for (int j = 0; j < solution.Maze.Width; j++)
                {
                    if (solution.Maze.NodeMatrix[i, j] != null)
                    {
                        solution.Maze.NodeMatrix[i, j].Status = "Not visited";
                    }
                }
            }
        }

        public void resetPreviousNode(Solution solution)
        {
            for (int i = 0; i < solution.Maze.Depth; i++)
            {
                for (int j = 0; j < solution.Maze.Width; j++)
                {
                    if (solution.Maze.NodeMatrix[i, j] != null)
                    {
                        if (solution.Maze.NodeMatrix[i, j].Previous != null)
                        {
                            solution.Maze.NodeMatrix[i, j].Previous = null;
                        }
                    }                    
                }
            }
        }

        public void searchPath(Node currentNode, Solution solution)
        {
            Stack<Node> pathway = new Stack<Node>();
            Node tempNode = currentNode;
            pathway.Push(tempNode);
            while (true)
            {
                if (tempNode.Previous == null)
                {
                    break;
                }
                else
                {
                    pathway.Push(tempNode.Previous);
                    tempNode = tempNode.Previous;
                }
            }

            while (pathway.Count() != 0)
            {
                solution.Route.AddNodeToSelectedRoute(pathway.Pop());
            }
        }
    }
}
