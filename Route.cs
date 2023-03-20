using NodeFile;

namespace RouteFile
{
    class Route
    {
        // === ATTRIBUTES ======================================================================
        private int nRouteGraph;
        private Node?[] routeGraph;
        private int nRouteSteps;
        private string?[] routeSteps;

        // === CONSTRUCTOR =====================================================================
        public Route()
        {
            this.routeGraph = new Node[100];
            this.routeSteps = new string[100];
            this.nRouteGraph = 0;
            this.nRouteSteps = 0;
        }

        // === GETTER SETTER ===================================================================
        public int getNRouteGraph()
        {
            return this.nRouteGraph;
        }

        public int getNRouteSteps()
        {
            return this.nRouteSteps;
        }

        public Node? getNodeRoute(int idx)
        {
            return routeGraph[idx];
        }

        public string? getStepRoute(int idx)
        {
            return routeSteps[idx];
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
            this.nRouteGraph++;
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
            this.nRouteGraph--;
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
            this.nRouteSteps++;
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
            this.nRouteSteps--;
        }
    }
}