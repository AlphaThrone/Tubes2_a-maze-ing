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
        private Algorithm[] algorithms;
        private int selectedAlgorithm;

        // === CONSTRUCTOR =====================================================================
        public Controller()
        {
            this.maze = new Maze();
            this.algorithms = new Algorithm[2];
            this.algorithms[0] = new Bfs();
            this.algorithms[1] = new Dfs();
            this.selectedAlgorithm = -1;
        }

        // === GETTER SETTER ===================================================================
        public Maze Maze
        {
            get { return this.maze; }
            set { this.maze = value; }
        }

        public Algorithm[] Algorithms
        {
            get { return algorithms; }
            set { this.algorithms = value; }
        }

        public int SelectedAlgorithm
        {
            get { return selectedAlgorithm; }
            set { selectedAlgorithm = value; }
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
