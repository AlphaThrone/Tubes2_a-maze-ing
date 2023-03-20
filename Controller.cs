using MazeFile;
using SolutionFile;
using System;
using SolverFile;

namespace ControllerFile
{
    class Controller
    {
        // === ATTRIBUTES ======================================================================
        private Maze maze;
        private Solution[] solutions;

        // === CONSTRUCTOR =====================================================================
        public Controller()
        {
            this.maze = new Maze();
            this.solutions = new Solution[2];
        }

        // === METHODS =========================================================================
        public void importMaze()
        {
            bool inputInvalid = true;
            string inputFileName;

            while (inputInvalid)
            {
                Console.Write("Enter file name: ");
                try
                {
                    inputFileName = Console.ReadLine();
                    string inputFilePath = "./test/" + inputFileName + ".txt";
                    if (String.IsNullOrWhiteSpace(inputFileName))
                    {
                        throw new Exception("Filename cannot be empty\n");
                    }
                    if (!File.Exists(inputFilePath))
                    {
                        throw new Exception("We cannot find your file :(\n");
                    }

                    this.maze.setMazeFile(inputFileName);
                    this.maze.validate();
                    this.maze.build();
                    this.maze.displayMaze();
                    Console.WriteLine(this.maze.getNTreasure());

                    inputInvalid = false;
                }
                catch (Exception err)
                {
                    Console.WriteLine(err.Message);
                }
            }
        }

        public void solve()
        {
            Solver solver = new Solver();
            string menu;

            bool isValid = false;
            while (!isValid)
            {
                try
                {
                    Console.Write("BFS/DFS: ");
                    menu = Console.ReadLine();

                    if (menu != "DFS")
                    {
                        throw new Exception("Menu invalid");
                    }

                    if (menu == "DFS")
                    {
                        this.solutions[1] = solver.solve(1, maze);
                        this.displaySolution(1);
                    }

                    isValid = true;
                }
                catch (Exception err)
                {
                    Console.WriteLine(err.Message);
                }
            }


        }

        // === DISPLAY =========================================================================
        public void displayMazeFilePath()
        {
            Console.WriteLine(maze.getMazeFilePath());
        }

        public void displayMazeFileName()
        {
            Console.WriteLine(maze.getMazeFileName());
        }

        public void displaySolution(int id)
        {
            Console.WriteLine();
            Console.WriteLine("SOLUTION");
            Console.WriteLine("Algorithm\t: " + this.solutions[id].getAlgorithmName());
            Console.WriteLine("Execution time\t: " + this.solutions[id].getExecutionTime() + " ms");
            Console.WriteLine("Visited Node\t: " + this.solutions[id].getVisitedNode() + " nodes");

            Console.Write("Route\t\t: ");
            for (int i = 0; i < 100; i++)
            {
                if (this.solutions[id].getRoute().getNodeRoute(i) == null)
                {
                    break;
                }

                Console.Write("(" + this.solutions[id].getRoute().getNodeRoute(i).getPosX() + "," + this.solutions[id].getRoute().getNodeRoute(i).getPosY() + ") ");
            }
            Console.WriteLine();

            Console.Write("Steps\t\t: ");
            for (int i = 0; i < 100; i++)
            {
                if (this.solutions[id].getRoute().getStepRoute(i) == null)
                {
                    break;
                }

                Console.Write(this.solutions[id].getRoute().getStepRoute(i) + " ");
            }
            Console.Write("(" + this.solutions[id].getRoute().getNRouteSteps() + " steps)");
            Console.WriteLine();
        }

    }
}
