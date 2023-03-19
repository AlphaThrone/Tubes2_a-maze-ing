namespace amazeing
{
    class Controller
    {
        // Attributes
        private Maze maze;

        // Constructor Destructor
        public Controller()
        {
            this.maze = new Maze();
        }

        // Initializer
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
                    this.maze.build();

                    inputInvalid = false;
                }
                catch (Exception err)
                {
                    Console.WriteLine(err.Message);
                }
            }
        }

        // Display
        public void displayMazeFilePath()
        {
            Console.WriteLine(maze.getMazeFilePath());
        }

        public void displayMazeFileName()
        {
            Console.WriteLine(maze.getMazeFileName());
        }

    }
}
