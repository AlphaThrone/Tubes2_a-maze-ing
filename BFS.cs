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
        // === CONSTRUCTOR =====================================================================
        public BFS() : base("BFS") { }

        // === METHODS =========================================================================
        public override Solution use(Solution solution)
        {
            //Kamus
            Solution newSolution = solution;
            Queue<Route> nodeQueue = new Queue<Route>();
            Route tempRoute = new Route();
            Route tempRoute4=new Route();
            Route tempRoute3=new Route();
            Route tempRoute2=new Route();
            Route tempRoute1=new Route();
            Node tempNode = solution.getMaze().getStartingNode();
            int treasureFound=0;
            int count=0;
            
            
            //Algoritma
            solution.getMaze().getStartingNode().setStatus("Checking");
            solution.getRoute().addNodeToRoute(solution.getMaze().getStartingNode());
            Search(solution, solution.getMaze().getStartingNode(), nodeQueue, solution.getRoute(), tempRoute1, tempRoute2, tempRoute3, tempRoute4);
            solution.setVisitedNode(solution.getVisitedNode()+1);

            while(nodeQueue.Count()!=0){
                count++;
                Console.WriteLine(count);
                Console.WriteLine("in Queue: "+nodeQueue.Count());
                tempRoute=nodeQueue.Dequeue();
                tempNode = tempRoute.getNodeRoute(tempRoute.getNumNodeRoute()-1);
                Console.WriteLine(tempNode.getStatus());
                // if(tempNode.getStatus()=="Visited"){
                //     continue;
                // }
                tempNode.setStatus("Visited");

                if(tempNode.getType()=="Treasure"){
                    treasureFound++;
                    Console.WriteLine("masok treasure");
                    solution.getRoute().setRoute(tempRoute);
                    // solution.getRoute().addNodeToRoute(tempNode);
                    // tempRoute=new Route();
                    Console.WriteLine("masok clean");
                }
                if((treasureFound)==solution.getMaze().getNTreasure()){
                    
                    break;
                }
                Console.WriteLine("masok node");
                Search(solution, tempNode, nodeQueue,tempRoute, tempRoute1, tempRoute2, tempRoute3, tempRoute4);
            }
            
            return newSolution;
        }

        public void Search(Solution solution, Node currentNode, Queue<Route> nodeQueue,Route tempRoute, Route tempRoute1, Route tempRoute2, Route tempRoute3, Route tempRoute4){

            currentNode.printNode();
            if(currentNode.getLeftNode()!=null && currentNode.getLeftNode().getStatus()=="Not visited" ){
                tempRoute1=tempRoute;
                tempRoute1.addNodeToRoute(currentNode.getLeftNode());
                tempRoute1.addStepToRoute("L");
                nodeQueue.Enqueue(tempRoute1);
                currentNode.getLeftNode().setStatus("Checking");
                Console.WriteLine("masok kiri");
                solution.setVisitedNode(solution.getVisitedNode()+1);
                
            }
            if(currentNode.getTopNode()!=null && currentNode.getTopNode().getStatus()=="Not visited"){
                tempRoute2=tempRoute;
                tempRoute2.addNodeToRoute(currentNode.getTopNode());
                tempRoute2.addStepToRoute("U");
                nodeQueue.Enqueue(tempRoute2);
                currentNode.getTopNode().setStatus("Checking");
                Console.WriteLine("masok atas");
                solution.setVisitedNode(solution.getVisitedNode()+1);
                
            }
            if(currentNode.getBottomNode()!=null && currentNode.getBottomNode().getStatus()=="Not visited"){
                tempRoute4=tempRoute;
                tempRoute4.addNodeToRoute(currentNode.getBottomNode());
                tempRoute4.addStepToRoute("D");
                currentNode.getBottomNode().setStatus("Checking");
                nodeQueue.Enqueue(tempRoute4);
                Console.WriteLine("masok bawah");
                solution.setVisitedNode(solution.getVisitedNode()+1);
            }
            if(currentNode.getRightNode()!=null && currentNode.getRightNode().getStatus()=="Not visited"){
                tempRoute3=tempRoute;
                tempRoute3.addNodeToRoute(currentNode.getRightNode());
                tempRoute3.addStepToRoute("R");
                nodeQueue.Enqueue(tempRoute3);
                currentNode.getRightNode().setStatus("Checking");
                Console.WriteLine("masok kanan");
                solution.setVisitedNode(solution.getVisitedNode()+1);

            }
        }
    }
}