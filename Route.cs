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
        private string[] routeSteps;
        private string routeStr;
        private int nSteps;

        // === CONSTRUCTOR =====================================================================
        public Route()
        {
            this.routeGraph = new Node[100];
            this.routeSteps = new string[100];
            this.routeStr = "-";
            this.nSteps = 0;
        }

        // === GETTER SETTER ===================================================================
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
                    routeGraph[i] = newNode;
                    break;
                }
            }
        }

        public void RemoveNodeFromRoute()
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
                if (this.routeGraph[i] == null)
                {
                    break;
                }

                if (this.routeGraph[i - 1].Y - 1 == this.routeGraph[i].Y)
                {
                    AddStepToRoute("L");
                    this.routeStr = this.routeStr + "L ";
                }
                if (this.routeGraph[i - 1].X - 1 == this.routeGraph[i].X)
                {
                    AddStepToRoute("U");
                    this.routeStr = this.routeStr + "U ";
                }
                if (this.routeGraph[i - 1].Y + 1 == this.routeGraph[i].Y)
                {
                    AddStepToRoute("R");
                    this.routeStr = this.routeStr + "R ";
                }
                if (this.routeGraph[i - 1].X + 1 == this.routeGraph[i].X)
                {
                    AddStepToRoute("D");
                    this.routeStr = this.routeStr + "D ";
                }
            }
        }
    }
}
