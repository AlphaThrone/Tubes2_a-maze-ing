namespace amazeing
{
    class Maze
    {
        // Attributes
        private string fileName;
        private string filePath;
        private int width;
        private int depth;

        // Constructor Destructor
        public Maze()
        {
            this.fileName = "";
            this.filePath = "./test/";
            this.width = 0;
            this.depth = 0;
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

        // Methods
        public void build()
        {
            string[] lines = File.ReadAllLines(this.filePath);
            this.depth = lines.Length;
            this.width = lines[0].Length - this.depth + 1;

            // File Validation
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
    }
}