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
    }
}