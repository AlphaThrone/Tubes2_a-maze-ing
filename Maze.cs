using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazeing
{
    public class Maze
    {
        // === ATTRIBUTES ======================================================================
        private string file;

        // === CONSTRUCTOR =====================================================================
        public Maze()
        {
            this.file = "";
        }

        // === GETTER SETTER ===================================================================
       public string File
        {
            get { return this.file; }
            set { this.file = value; }
        }

    }
}
