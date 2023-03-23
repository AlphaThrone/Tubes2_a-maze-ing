using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Amazeing
{
    internal class Controller
    {
        // === ATTRIBUTES ======================================================================
        private Maze maze;

        // === CONSTRUCTOR =====================================================================
        public Controller()
        {
            this.maze = new Maze();
        }

        // === GETTER SETTER ===================================================================
        public Maze Maze
        {
            get { return this.maze; }
            set { this.maze = value; }
        }

        // === METHODS =========================================================================
        public void importMaze(string file)
        {
            this.maze.SourceFile = file;
            try
            {
                this.maze.validate();
            }
            catch (Exception err)
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(err.Message, "Invalid file", buttons, MessageBoxIcon.Error);
            }
        }
    }
}
