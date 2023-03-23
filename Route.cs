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
        private int nSteps;

        // === CONSTRUCTOR =====================================================================
        public Route()
        {
            this.routeGraph = new Node[100];
            this.routeSteps = new string[100];
            this.nSteps = 0;
        }
    }
}
