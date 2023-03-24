using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Amazeing
{
    public class Route
    {
        // === ATTRIBUTES ======================================================================
        private Node[] routeGraph;
        private Node[] selectedRouteGraph;
        private int nSelectedRoute;
        private string[] routeSteps;
        private string routeStr;
        private int nSteps;

        // === CONSTRUCTOR =====================================================================
        public Route()
        {
            this.routeGraph = new Node[100];
            this.selectedRouteGraph = new Node[100];
            this.nSelectedRoute = 0;
            this.routeSteps = new string[100];
            this.routeStr = "-";
            this.nSteps = 0;
        }

        // === GETTER SETTER ===================================================================
        public Node[] RouteGraph
        {
            get { return this.routeGraph; }
            set { this.routeGraph = value; }
        }

        public Node[] SelectedRouteGraph
        {
            get { return this.selectedRouteGraph; }
            set { this.selectedRouteGraph = value; }
        }

        public int NSelectedRoute
        {
            get { return this.nSelectedRoute; }
            set { this.nSelectedRoute = value; }
        }

        public int Steps
        {
            get { return this.nSteps; }
            set { this.nSteps = value; }
        }

        public string RouteStr
        {
            get { return this.routeStr; }
            set { this.routeStr = value; }
        }

        // === METHODS =========================================================================
        public void AddNodeToRoute(Node newNode)
        {
            for (int i = 0; i < 100; i++)
            {
                if (routeGraph[i] == null)
                {
                    if (i > 0)
                    {
                        if (routeGraph[i - 1].X != newNode.X || routeGraph[i - 1].Y != newNode.Y)
                        {
                            routeGraph[i] = newNode;
                        }
                    }
                    else
                    {
                        routeGraph[i] = newNode;
                    }
                    break;
                }
            }
        }

        public void AddNodeToSelectedRoute(Node newNode)
        {
            for (int i = 0; i < 100; i++)
            {
                if (selectedRouteGraph[i] == null)
                {
                    if (i > 0)
                    {
                        if (selectedRouteGraph[i - 1].X != newNode.X || selectedRouteGraph[i - 1].Y != newNode.Y)
                        {
                            selectedRouteGraph[i] = newNode;
                        }
                    }
                    else
                    {
                        selectedRouteGraph[i] = newNode;
                    }
                    break;
                }
            }
            this.nSelectedRoute++;
        }

        public void RemoveNodeFromSelectedRoute()
        {
            for (int i = 0; i < 100; i++)
            {
                if (selectedRouteGraph[i] == null)
                {
                    selectedRouteGraph[i - 1] = null;
                    break;
                }
            }
            this.nSelectedRoute--;
        }

        public void AddStepToRoute(string newStep)
        {
            for (int i = 0; i < 100; i++)
            {
                if (routeSteps[i] == null)
                {
                    routeSteps[i] = newStep;
                    break;
                }
            }
            this.nSteps++;
        }

        public void InitializeStep()
        {
            this.routeStr = "";
            for (int i = 1; i < 100; i++)
            {
                if (this.selectedRouteGraph[i] == null)
                {
                    break;
                }

                if (this.selectedRouteGraph[i - 1].Y - 1 == this.selectedRouteGraph[i].Y)
                {
                    AddStepToRoute("L");
                    this.routeStr = this.routeStr + "L ";
                }
                if (this.selectedRouteGraph[i - 1].X - 1 == this.selectedRouteGraph[i].X)
                {
                    AddStepToRoute("U");
                    this.routeStr = this.routeStr + "U ";
                }
                if (this.selectedRouteGraph[i - 1].Y + 1 == this.selectedRouteGraph[i].Y)
                {
                    AddStepToRoute("R");
                    this.routeStr = this.routeStr + "R ";
                }
                if (this.selectedRouteGraph[i - 1].X + 1 == this.selectedRouteGraph[i].X)
                {
                    AddStepToRoute("D");
                    this.routeStr = this.routeStr + "D ";
                }
            }
        }
    }
}
