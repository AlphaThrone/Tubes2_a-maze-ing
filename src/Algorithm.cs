using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazeing
{
    public abstract class Algorithm
    {
        // === ATTRIBUTES ======================================================================
        private int id;
        private string name;
        private string fullName;
        private string desc;

        // === CONSTRUCTOR =====================================================================
        public Algorithm()
        {
            this.id = -1;
            this.name = "XXX";
            this.fullName = "XXX";
            this.desc = "XXX";
        }

        public Algorithm(string name)
        {
            if (name == "BFS")
            {
                this.id = 0;
                this.fullName = "Breadth First Search";
                this.desc = "Breadth-first search proceeds in a concentric manner by visitting first all the vertices that are adjacent to a starting vertex, then all unvisited vertices two edges apart from it, and so on, untill all the vertices in the same connected component as the starting vertex are visited.";
            }
            else if (name == "DFS")
            {
                this.id = 1;
                this.fullName = "Depth First Search";
                this.desc = "Breadth-first search proceeds in a concentric manner by visitting first all the vertices that are adjacent to a starting vertex, then all unvisited vertices two edges apart from it, and so on, untill all the vertices in the same connected component as the starting vertex are visited.";
            }
            else
            {
                throw new Exception("invalid algorithm\n");
            }
        }

        // === GETTER SETTER ===================================================================
        public string Desc
        {
            get { return this.desc; }
            set { this.desc = value; }
        }

        // === METHODS =========================================================================
        public abstract Solution Use(Solution prevSolution);
    }
}
