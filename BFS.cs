using AlgorithmFile;
using System;
using NodeFile;
using SolutionFile;
using System;
using System.Collections.Generic;
using RouteFile;

namespace BFSFile
{
    class BFS : Algorithm
    {
        // === ATTRIBUTES ======================================================================
        private Queue<Node> nodeQueue;
        // === CONSTRUCTOR =====================================================================
        public BFS() : base("BFS") { }

        // === METHODS =========================================================================
        public override Solution use(Solution solution)
        {
            bool cleared=false;
            this.nodeQueue = new Queue<Node>();
            Solution newSolution = solution;
            Node currentNode=newSolution.getMaze().getStartingNode();
            List<Node> treasureFound = new List<Node>();
            List<Node> allTreasures = getAllTreasure(solution);

            this.nodeQueue.Enqueue(solution.getMaze().getStartingNode());
            while (true){
                currentNode = this.nodeQueue.Dequeue();
                newSolution.getRoute().addNodeToRoute(currentNode);
                if(currentNode.getStatus() != "Visited"){
                    newSolution.setVisitedNode(newSolution.getVisitedNode()+1);
                }
                if(currentNode.getType()=="Treasure" && currentNode.getStatus()!= "Visited" && !isAlreadyFound(currentNode, treasureFound)){
                    newSolution.setTreasureFound(newSolution.getTreasureFound() + 1);
                    treasureFound.Add(currentNode);
                    
                    Console.WriteLine("TREASURE FOUND: " + newSolution.getTreasureFound() + " id: " + currentNode.getPosX() + "," + currentNode.getPosY());
                    for (int i = 0; i < newSolution.getRoute().getNumNodeRoute(); i++)
                    {
                        newSolution.getRoute().getNodeRoute(i).setStatus("Not visited");
                    }
                    nodeQueue.Clear();
                    
                    if (isAllTreasuresFound(treasureFound, allTreasures))
                    {
                        for (int i = 0; i < newSolution.getRoute().getNumNodeRoute(); i++)
                        {
                            newSolution.getRoute().getNodeRoute(i).setStatus("Visited");
                        }
                        break;
                    }
                }
                currentNode.setStatus("Checking");

                search(newSolution, currentNode);

                currentNode.setStatus("Visited");
                


            }
            
            return newSolution;
        }

        public void search(Solution solution, Node currentNode){

            currentNode.printNode();
            if(currentNode.getLeftNode()!=null && currentNode.getLeftNode().getStatus()=="Not visited" && !nodeQueue.Contains(currentNode.getLeftNode())){
                this.nodeQueue.Enqueue(currentNode.getLeftNode());
                solution.setVisitedNode(solution.getVisitedNode()+1);
            }
            if(currentNode.getTopNode()!=null && currentNode.getTopNode().getStatus()=="Not visited" && !nodeQueue.Contains(currentNode.getTopNode())){
                this.nodeQueue.Enqueue(currentNode.getTopNode());
                solution.setVisitedNode(solution.getVisitedNode()+1);
                
            }
            if(currentNode.getRightNode()!=null && currentNode.getRightNode().getStatus()=="Not visited" && !nodeQueue.Contains(currentNode.getRightNode())){
                this.nodeQueue.Enqueue(currentNode.getRightNode());
                solution.setVisitedNode(solution.getVisitedNode()+1);
            }
            if(currentNode.getBottomNode()!=null && currentNode.getBottomNode().getStatus()=="Not visited" && !nodeQueue.Contains(currentNode.getBottomNode())){
                this.nodeQueue.Enqueue(currentNode.getBottomNode());
                solution.setVisitedNode(solution.getVisitedNode()+1);
            }
        }

        public bool isAllTreasuresFound(List<Node> treasures, List<Node> allTreasures){
            if(treasures.Count()==allTreasures.Count()){
                int count=0;
                for (int j = 0; j < allTreasures.Count(); j++)
                {
                    if(treasures.Contains(allTreasures[j])){
                        count++;
                    }
                }
                return count==allTreasures.Count();
            } else {
                return false;
            }
            
        }

        public List<Node> getAllTreasure(Solution solution){
            List<Node> allTreasures = new List<Node>();
            for (int i = 0; i < solution.getMaze().getMazeWidth(); i++)
            {
                for (int j = 0; j < solution.getMaze().getMazeDepth(); j++)
                {
                    if(solution.getMaze().getMatrix()[i,j]?.getType()=="Treasure"){
                        allTreasures.Add(solution.getMaze().getMatrix()[i,j]);
                    }
                }
            }
            return allTreasures;
        }

        public bool isAlreadyFound(Node treasure, List<Node> founded){
            for (int i = 0; i < founded.Count(); i++)
            {
                if(treasure==founded[i]){
                    return true;
                }
            }
            return false;
        }
    }
}