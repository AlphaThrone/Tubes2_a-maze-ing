namespace amazeing
{
    class DFS : Algorithm
    {
        // === ATTRIBUTES ======================================================================
        private static bool keepRoute = false;

        // === CONSTRUCTOR =====================================================================
        public DFS() : base("DFS") { }

        // === METHODS =========================================================================
        public override Solution use(Node currentNode, Solution prevSolution, string currentStep)
        {
            Solution solution = prevSolution;

            // 1. Update node status
            currentNode.setStatus("Checking");

            // 2. Update route graph
            solution.getRoute().addNodeToRoute(currentNode);

            // 3. Update treasure found
            if (currentNode.getType() == "Treasure")
            {
                solution.setTreasureFound(solution.getTreasureFound() + 1);
                Console.WriteLine("FOUND TREASURE : " + solution.getTreasureFound());
            }

            // 4. Update node status
            currentNode.setStatus("Route");

            // 5. Go to left node if exists
            if (currentNode.getLeftNode() != null && currentNode.getLeftNode().getStatus() == "Not visited" && solution.getTreasureFound() != solution.getMaze().getNTreasure())
            {
                keepRoute = false;
                solution.getRoute().addStepToRoute("L");
                solution = use(currentNode.getLeftNode(), solution, "L");
            }

            // 6. Go to top node if exists
            if (currentNode.getTopNode() != null && currentNode.getTopNode().getStatus() == "Not visited" && solution.getTreasureFound() != solution.getMaze().getNTreasure())
            {
                keepRoute = false;
                solution.getRoute().addStepToRoute("U");
                solution = use(currentNode.getTopNode(), solution, "U");
            }

            // 7. Go to right node if exists
            if (currentNode.getRightNode() != null && currentNode.getRightNode().getStatus() == "Not visited" && solution.getTreasureFound() != solution.getMaze().getNTreasure())
            {
                keepRoute = false;
                solution.getRoute().addStepToRoute("R");
                solution = use(currentNode.getRightNode(), solution, "R");
            }

            // 8. Go to bottom node if exists
            if (currentNode.getBottomNode() != null && currentNode.getBottomNode().getStatus() == "Not visited" && solution.getTreasureFound() != solution.getMaze().getNTreasure())
            {
                keepRoute = false;
                solution.getRoute().addStepToRoute("D");
                solution = use(currentNode.getBottomNode(), solution, "D");
            }

            // 9. Backtrack
            if (solution.getTreasureFound() != solution.getMaze().getNTreasure())
            {
                if (currentNode.getType() == "Treasure")
                {
                    keepRoute = true;
                }

                if (!keepRoute)
                {
                    solution.getRoute().removeStepFromRoute();
                    solution.getRoute().removeNodeFromRoute();
                    currentNode.setStatus("Visited");
                }
                else
                {
                    solution.getRoute().addNodeToRoute(currentNode);
                    if (currentStep == "L")
                    {
                        solution.getRoute().addStepToRoute("R");
                    }
                    else if (currentStep == "U")
                    {
                        solution.getRoute().addStepToRoute("D");
                    }
                    else if (currentStep == "R")
                    {
                        solution.getRoute().addStepToRoute("L");
                    }
                    else if (currentStep == "D")
                    {
                        solution.getRoute().addStepToRoute("U");
                    }
                }
            }

            return solution;
        }
    }
}