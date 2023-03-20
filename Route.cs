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