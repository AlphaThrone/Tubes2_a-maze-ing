using NodeFile;

namespace NodeFile
{
    class Node
    {
        // === ATTRIBUTES ======================================================================
        private int id;
        private string type;
        private string status;
        private int posX;
        private int posY;
        private Node? leftNode;
        private Node? topNode;
        private Node? rightNode;
        private Node? bottomNode;
        private Node? previousNode;
        private static int numOfNode = 0;

        // === CONSTRUCTOR =====================================================================
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

            this.status = "Not visited";
            this.posX = posX;
            this.posY = posY;

            numOfNode++;
        }

        // === GETTER SETTER ===================================================================
        public int getPosX()
        {
            return this.posX;
        }

        public int getPosY()
        {
            return this.posY;
        }

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
        public Node getTopNode()
        {
            return this.topNode;
        }
        public void setRightNode(Node rightNode)
        {
            this.rightNode = rightNode;
        }
        public Node getRightNode()
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
        public void setPreviousNode(Node previousNode)
        {
            this.previousNode = previousNode;
        }
        public Node? getPreviousNode(){
            return this.previousNode;
        }

        public string getType()
        {
            return this.type;
        }

        public void setStatus(string status)
        {
            this.status = status;
        }

        public string getStatus()
        {
            return this.status;
        }
        public void printNode(){
            Console.WriteLine("("+getPosX()+","+getPosY()+")");
        }

        // === METHODS =========================================================================
        public bool isAdjacent(Node other)
        {
            if (this.posX + 1 == other.posX || this.posX - 1 == other.posX)
            {
                return true;
            }
            if (this.posY + 1 == other.posY || this.posY - 1 == other.posY)
            {
                return true;
            }
            return false;
        }

        public bool isExplorable()
        {
            if (this.getLeftNode() != null && this.getLeftNode().getStatus() == "Not visited")
            {
                return true;
            }
            if (this.getTopNode() != null && this.getTopNode().getStatus() == "Not visited")
            {
                return true;
            }
            if (this.getRightNode() != null && this.getRightNode().getStatus() == "Not visited")
            {
                return true;
            }
            if (this.getBottomNode() != null && this.getBottomNode().getStatus() == "Not visited")
            {
                return true;
            }
            return false;
        }
    }
}