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
            bool clearing=false;
            this.nodeQueue = new Queue<Node>();
            Solution newSolution = solution;
            Node currentNode=newSolution.getMaze().getStartingNode();
            Route tempRoute=new Route();
            List<Node> treasureFound = new List<Node>();
            List<Node> allTreasures = getAllTreasure(solution);

            this.nodeQueue.Enqueue(solution.getMaze().getStartingNode());
            while (true){
                currentNode = this.nodeQueue.Dequeue();
                tempRoute.addNodeToRoute(currentNode);
                if(currentNode.getStatus() != "Visited"){
                    newSolution.setVisitedNode(newSolution.getVisitedNode()+1);
                }

                if(currentNode.getType()=="Treasure" && currentNode.getStatus()!= "Visited" && !isAlreadyFound(currentNode, treasureFound)){
                    newSolution.setTreasureFound(newSolution.getTreasureFound() + 1);
                    treasureFound.Add(currentNode);
                    
                    Console.WriteLine("TREASURE FOUND: " + newSolution.getTreasureFound() + " id: " + currentNode.getPosX() + "," + currentNode.getPosY());
                    
                    tempRoute=searchPath(currentNode, newSolution);
                    for (int i = 0; i < tempRoute.getNumNodeRoute(); i++)
                    {
                        solution.getRoute().addNodeToRoute(tempRoute.getNodeRoute(i));
                    }
                    resetPreviousNode(newSolution);
                    resetStatus(newSolution);
                    nodeQueue.Clear();
                    
                    if (isAllTreasuresFound(treasureFound, allTreasures))
                    {
                        for (int i = 0; i < solution.getRoute().getNumNodeRoute(); i++)
                        {
                            solution.getRoute().getNodeRoute(i).setStatus("Visited");
                        }
                        break;
                    }
                }

                search(newSolution, currentNode);

                currentNode.setStatus("Visited");
                


            }
            
            return solution;
        }

        public void search(Solution solution, Node currentNode){
            currentNode.setStatus("Checking");
            if(currentNode.getLeftNode()!=null && currentNode.getLeftNode().getStatus()=="Not visited" && !nodeQueue.Contains(currentNode.getLeftNode())){
                currentNode.getLeftNode().setPreviousNode(currentNode);
                this.nodeQueue.Enqueue(currentNode.getLeftNode());
            }
            if(currentNode.getTopNode()!=null && currentNode.getTopNode().getStatus()=="Not visited" && !nodeQueue.Contains(currentNode.getTopNode())){
                currentNode.getTopNode().setPreviousNode(currentNode);
                this.nodeQueue.Enqueue(currentNode.getTopNode());
            }
            if(currentNode.getRightNode()!=null && currentNode.getRightNode().getStatus()=="Not visited" && !nodeQueue.Contains(currentNode.getRightNode())){
                currentNode.getRightNode().setPreviousNode(currentNode);
                this.nodeQueue.Enqueue(currentNode.getRightNode());
                
            }
            if(currentNode.getBottomNode()!=null && currentNode.getBottomNode().getStatus()=="Not visited" && !nodeQueue.Contains(currentNode.getBottomNode())){
                currentNode.getBottomNode().setPreviousNode(currentNode);
                this.nodeQueue.Enqueue(currentNode.getBottomNode());
                
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

        public void resetStatus(Solution solution){
            for (int i = 0; i < solution.getMaze().getMazeWidth(); i++)
            {
                for (int j = 0; j < solution.getMaze().getMazeDepth(); j++)
                {
                    solution.getMaze().getMatrix()[i,j]?.setStatus("Not visited");
                }
            }
        }

        public void resetPreviousNode(Solution solution){
            for (int i = 0; i < solution.getMaze().getMazeWidth(); i++)
            {
                for (int j = 0; j < solution.getMaze().getMazeDepth(); j++)
                {
                    solution.getMaze().getMatrix()[i,j]?.setPreviousNode(null);
                }
            }
        }

        public Route searchPath(Node currentNode, Solution solution){
            Stack<Node> pathway = new Stack<Node>();
            Route tempRoute = new Route();
            Node tempNode=currentNode;
            pathway.Push(tempNode);
            while(true){
                if(tempNode.getPreviousNode()==null ){
                    break;
                } else {
                    pathway.Push(tempNode.getPreviousNode());
                    tempNode=tempNode.getPreviousNode();
                }
            }
            
            while (pathway.Count()!=0)
            {
                tempRoute.addNodeToRoute(pathway.Pop());    
            }
            return tempRoute;
        }
    }
}