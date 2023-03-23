using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazeing
{
    public class Node
    {
        // === ATTRIBUTES ======================================================================
        private int id;
        private string type;
        private string status;
        private int posX;
        private int posY;
        private Node leftNode;
        private Node topNode;
        private Node rightNode;
        private Node bottomNode;
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

            this.status = "Not visited";
            this.posX = posX;
            this.posY = posY;

            numOfNode++;
        }

        // === GETTER SETTER ===================================================================
        public string Status
        {
            get { return this.status; }
            set { this.status = value; }
        }

        public Node Left
        { 
            get { return this.leftNode; } 
            set { this.leftNode = value; } 
        }

        public Node Top
        {
            get { return this.topNode; }
            set { this.topNode = value; }
        }

        public Node Right
        {
            get { return this.rightNode; }
            set { this.rightNode = value; }
        }

        public Node Bottom
        {
            get { return this.bottomNode; }
            set { this.bottomNode = value; }
        }
    }
}
