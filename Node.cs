namespace amazeing
{
    class Node
    {
        // Attributes
        private int id;
        private string type;
        private string colour;
        private int posX;
        private int posY;
        private Node? leftNode;
        private Node? topNode;
        private Node? rightNode;
        private Node? bottomNode;
        private static int numOfNode = 0;

        // Constructor
        public Node(char symbol, int posX, int posY)
        {
            this.id = numOfNode;

            if (symbol == 'R')
            {
                this.type = "Path";
            }
            else if (symbol == 'T')
            {
                this.type = "Treasure";
            }
            else if (symbol == 'K')
            {
                this.type = "Krusty Krab";
            }
            else
            {
                throw new Exception("Maze file contains invalid character");
            }

            this.colour = "Dark Brown";
            this.posX = posX;
            this.posY = posY;

            numOfNode++;
        }

        // Getter Setter
        public void setLeftNode(Node leftNode)
        {
            this.leftNode = leftNode;
        }
        public Node getLeftNode()
        {
            return this.leftNode;
        }
        public void setTopNode(Node topNode)
        {
            this.topNode = topNode;
        }
        public Node getTopeNode()
        {
            return this.topNode;
        }
        public void setRightNode(Node rightNode)
        {
            this.rightNode = rightNode;
        }
        public Node getRighteNode()
        {
            return this.rightNode;
        }
        public void setBottomNode(Node bottomNode)
        {
            this.bottomNode = bottomNode;
        }
        public Node getBottomNode()
        {
            return this.bottomNode;
        }

        public string getType()
        {
            return this.type;
        }
    }
}