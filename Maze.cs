namespace amazeing
{
    class Maze
    {
        // Attributes
        private string fileName;
        private string filePath;
        private int width;
        private int depth;
        private Node? startingNode;
        private Node?[,]? matrix;
        private int nTreasure;

        // Constructor Destructor
        public Maze()
        {
            this.fileName = "";
            this.filePath = "./test/";
            this.width = 0;
            this.depth = 0;
            this.nTreasure = 0;
        }

        // Getter Setter
        public void setMazeFile(string fileName)
        {
            this.fileName = fileName;
            this.filePath = "./test/" + fileName + ".txt";
        }

        public string getMazeFileName()
        {
            return this.fileName;
        }

        public string getMazeFilePath()
        {
            return this.filePath;
        }

        public int getNTreasure()
        {
            return this.nTreasure;
        }

        // Methods
        public void validate()
        {
            string[] lines = File.ReadAllLines(this.filePath);
            this.depth = lines.Length;
            this.width = lines[0].Length - this.depth + 1;

            // File Validation (Must be a rectangle)
            if (this.width != this.depth)
            {
                throw new Exception("Maze must be a rectangle");
            }

            for (int i = 1; i < this.depth; i++)
            {
                if (this.width != lines[i].Length - this.depth + 1)
                {
                    throw new Exception("Maze must be a rectangle");
                }
            }
        }

        public void build()
        {
            string[] lines = File.ReadAllLines(this.filePath);
            this.depth = lines.Length;
            this.width = lines[0].Length - this.depth + 1;

            // Create all node
            this.matrix = new Node[this.depth, this.width];
            int x = 0;
            int y = 0;
            for (int i = 0; i < lines.Length; i++)
            {
                y = 0;
                x = i;
                for (int j = 0; j < lines[i].Length; j++)
                {
                    if (lines[i][j] != ' ')
                    {
                        if (lines[i][j] != 'X')
                        {
                            Node newNode = new Node(lines[i][j], x, y);
                            this.matrix[x, y] = newNode;

                            if (lines[i][j] == 'K')
                            {
                                this.startingNode = newNode;
                            }

                            if (lines[i][j] == 'T')
                            {
                                this.nTreasure++;
                            }
                        }
                        else
                        {
                            matrix[x, y] = null;
                        }
                        y++;
                    }
                }
            }

            // Link all nodes
            for (int i = 0; i < this.depth; i++)
            {
                for (int j = 0; j < this.width; j++)
                {
                    if (matrix[i, j] != null)
                    {
                        // Set left node
                        if (j != 0)
                        {
                            if (matrix[i, j - 1] != null)
                            {
                                matrix[i, j].setLeftNode(matrix[i, j - 1]);
                            }
                        }
                        // Set top node
                        if (i != 0)
                        {
                            if (matrix[i - 1, j] != null)
                            {
                                matrix[i, j].setTopNode(matrix[i - 1, j]);
                            }
                        }
                        // Set right node
                        if (j != this.width - 1)
                        {
                            if (matrix[i, j + 1] != null)
                            {
                                matrix[i, j].setRightNode(matrix[i, j + 1]);
                            }
                        }
                        // Set bottom node
                        if (i != this.depth - 1)
                        {
                            if (matrix[i + 1, j] != null)
                            {
                                matrix[i, j].setBottomNode(matrix[i + 1, j]);
                            }
                        }
                    }
                }
            }
        }

        // Display
        public void displayMaze()
        {
            for (int i = 0; i < this.depth; i++)
            {
                for (int j = 0; j < this.width; j++)
                {
                    if (this.matrix[i, j] == null)
                    {
                        Console.Write('X');
                    }
                    else if (this.matrix[i, j].getType() == "Path")
                    {
                        Console.Write('R');
                    }
                    else if (this.matrix[i, j].getType() == "Treasure")
                    {
                        Console.Write('T');
                    }
                    else if (this.matrix[i, j].getType() == "Krusty Krab")
                    {
                        Console.Write('K');
                    }
                    Console.Write(' ');
                }
                Console.WriteLine();
            }
        }
    }
}