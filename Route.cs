using NodeFile;

namespace RouteFile
{
    class Route
    {
        // === ATTRIBUTES ======================================================================
        private Node?[] routeGraph;
        private string?[] routeSteps;

        // === CONSTRUCTOR =====================================================================
        public Route()
        {
            this.routeGraph = new Node[100];
            this.routeSteps = new string[100];
        }

        // === GETTER SETTER ===================================================================
        public Node? getNodeRoute(int idx)
        {
            return routeGraph[idx];
        }

        public string? getStepRoute(int idx)
        {
            return routeSteps[idx];
        }
        public Node? getLastNodeRoute()
        {
            int i=0;
            while (routeGraph[i]!=null){
                i++;
            }
            return routeGraph[i];
        }
        public int getNumNodeRoute(){
            int count=0;
            for(int i=0; i < 100; i++){

                if(routeGraph[i]==null){
                    break;
                }
                count++;
                
            }
            return count;
        }
        public void setRoute(Route otherRoute)
        {
            for (int i = 0; i < 100; i++)
            {
                if (otherRoute.routeGraph[i] == null){
                    break;
                }else{
                    routeGraph[i] = otherRoute.routeGraph[i];
                }
            }
        }
        // === METHODS =========================================================================
        public void addNodeToRoute(Node newNode)
        {
            for (int i = 0; i < 100; i++)
            {
                if (routeGraph[i] == null)
                {
                    routeGraph[i] = newNode;
                    break;
                }
            }
        }

        public void removeNodeFromRoute()
        {
            for (int i = 0; i < 100; i++)
            {
                if (routeGraph[i] == null)
                {
                    routeGraph[i - 1] = null;
                    break;
                }
            }
        }

        public void addStepToRoute(string newStep)
        {
            for (int i = 0; i < 100; i++)
            {
                if (routeSteps[i] == null)
                {
                    routeSteps[i] = newStep;
                    break;
                }
            }
        }

        public void removeStepFromRoute()
        {
            for (int i = 0; i < 100; i++)
            {
                if (routeSteps[i] == null)
                {
                    routeSteps[i - 1] = null;
                    break;
                }
            }
        }
    }
}