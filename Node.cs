using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
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
        public int Id
        {
            get { return this.id; }
            set { this.id = value; }    
        }

        public string Type
        {
            get { return this.type; }
            set { this.type = value; }
        }

        public string Status
        {
            get { return this.status; }
            set { this.status = value; }
        }

        public int X
        {
            get { return this.posX; }
            set { this.posX = value; }
        }

        public int Y
        {
            get { return this.posY; }
            set { this.posY = value; }
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

        // === METHODS =========================================================================
        public bool IsExplorable()
        {
            if (this.Left != null && this.Left.Status == "Not visited")
            {
                return true;
            }
            if (this.Top != null && this.Top.Status == "Not visited")
            {
                return true;
            }
            if (this.Right != null && this.Right.Status == "Not visited")
            {
                return true;
            }
            if (this.Bottom != null && this.Bottom.Status == "Not visited")
            {
                return true;
            }
            return false;
        }
    }
}
