using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Amazeing
{
    public class Controller
    {
        // === ATTRIBUTES ======================================================================
        private Maze maze;
        private Algorithm[] algorithms;
        private int selectedAlgorithm;
        private Solution[] solutions;

        // === CONSTRUCTOR =====================================================================
        public Controller()
        {
            this.maze = new Maze();
            this.algorithms = new Algorithm[2];
            this.algorithms[0] = new Bfs();
            this.algorithms[1] = new Dfs();
            this.selectedAlgorithm = -1;
            this.solutions = new Solution[2];
        }

        // === GETTER SETTER ===================================================================
        public Maze Maze
        {
            get { return this.maze; }
            set { this.maze = value; }
        }

        public Algorithm[] Algorithms
        {
            get { return this.algorithms; }
            set { this.algorithms = value; }
        }

        public int SelectedAlgorithm
        {
            get { return this.selectedAlgorithm; }
            set { this.selectedAlgorithm = value; }
        }

        public Solution[] Solutions
        {
            get { return this.solutions; }
            set { this.solutions = value; }
        }

        // === METHODS =========================================================================
        public void ImportMaze(string file)
        {
            this.maze.SourceFile = file;
            this.maze.Validate();
            this.maze.Build();
        }

        public void Solve()
        {
            this.solutions[this.selectedAlgorithm] = new Solution(this.selectedAlgorithm, this.maze);

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            this.solutions[this.selectedAlgorithm] = this.algorithms[this.selectedAlgorithm].Use(this.solutions[this.selectedAlgorithm]);

            stopwatch.Stop();
            this.solutions[this.selectedAlgorithm].ExecTime = stopwatch.ElapsedMilliseconds;
        }
    }
}
