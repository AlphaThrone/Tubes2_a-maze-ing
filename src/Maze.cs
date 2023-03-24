using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.CompilerServices;

namespace Amazeing
{
    public class Maze
    {
        // === ATTRIBUTES ======================================================================
        private string sourceFile;
        private char[,] matrix;
        private Node[,] nodeMatrix;
        private int depth;
        private int width;
        private Node startingNode;
        private int nTreasure;

        // === CONSTRUCTOR =====================================================================
        public Maze()
        {
            this.sourceFile = "";
            this.depth = 0;
            this.width = 0;
            this.nTreasure = 0;
        }

        public Maze(Maze other)
        {
            this.sourceFile = other.sourceFile;
            this.Validate();
            this.Build();
        }

        // === GETTER SETTER ===================================================================
       public string SourceFile
        {
            get { return this.sourceFile; }
            set { this.sourceFile = value; }
        }

        public char[,] Matrix
        {
            get { return this.matrix; }
            set { this.matrix = value; }
        }

        public Node[,] NodeMatrix
        {
            get { return this.nodeMatrix; }
            set { this.nodeMatrix = value; }
        }

        public int Depth
        {
            get { return this.depth; }
            set { this.depth = value; }
        }
        public int Width
        {
            get { return this.width; }
            set { this.width = value; }
        }

        public Node StartingNode
        {
            get { return this.startingNode; }
            set { this.startingNode = value; }
        }

        public int NTreasure
        {
            get { return this.nTreasure; }
            set { this.nTreasure = value; }
        }

        // === METHODS =========================================================================
        public void Validate()
        {
            string[] lines = File.ReadAllLines(this.sourceFile);
            this.depth = lines.Length;
            this.width = lines[0].Replace(" ", "").Length;

            // 1. Is Empty validation
            if (this.depth == 0 && this.width == 0)
            {
                throw new Exception("File is empty");
            }

            // 2. Shape validation
            for (int i = 1; i < this.depth; i++)
            {
                if (this.width != lines[i].Replace(" ", "").Length)
                {
                    throw new Exception("Maze must be a rectangle");
                }
            }

            // 3. Character validation
            int krustyKrabCounter = 0;
            int treasureCounter = 0;

            for(int i = 0; i < lines.Length; i++)
            {
                for(int j = 0; j < lines[i].Length; j++)
                {
                    if (lines[i][j] == 'K')
                    {
                        krustyKrabCounter++;
                    }
                    else if (lines[i][j] == 'T')
                    {
                        treasureCounter++;
                    }
                    else
                    {
                        if (lines[i][j] != ' ' && lines[i][j] != 'X' && lines[i][j] != 'R')
                        {
                            throw new Exception("Invalid character found: " + lines[i][j]);
                        }
                    }
                }
            }

            if (krustyKrabCounter != 1)
            {
                throw new Exception("Maze must contain exactly 1 Krusty Krab");
            }
            if (treasureCounter < 1)
            {
                throw new Exception("Maze must contain at least 1 Treasure");
            }

            // 4. Build matrix representation
            this.matrix = new char[this.depth, this.width];
            int z = 0;
            for (int i = 0; i < lines.Length; i++)
            {
                z = 0;
                for (int k = 0; k < lines[0].Length; k++)
                {
                    if (lines[i][k] != ' ')
                    {
                        this.matrix[i, z] = lines[i][k];
                        z++;
                    }
                    
                }
            }
        }

        public void Build()
        {
            this.nodeMatrix = new Node[this.depth, this.width];

            // 1. Construct all nodes
            for(int i = 0; i < this.depth; i++)
            {
                for(int j = 0; j < this.width; j++)
                {
                    if (this.matrix[i,j] != 'X')
                    {
                        Node newNode = new Node(this.matrix[i, j], i, j);
                        newNode.Status = "Not visited";
                        nodeMatrix[i,j] = newNode;

                        if (this.matrix[i,j] == 'K')
                        {
                            this.startingNode = newNode;
                        }
                        else if (this.matrix[i,j] == 'T')
                        {
                            this.nTreasure++;
                        }
                    }
                    else
                    {
                        nodeMatrix[i, j] = null;
                    }
                }
            }

            // 2. Link all nodes
            for(int i = 0; i < this.depth; i++)
            {
                for (int j = 0; j < this.width; j++)
                {
                    if (nodeMatrix[i,j] != null)
                    {
                        // Set left node
                        if (j != 0)
                        {
                            if (nodeMatrix[i, j- 1] != null)
                            {
                                nodeMatrix[i, j].Left = nodeMatrix[i, j - 1];
                            }
                        }

                        // Set top node
                        if (i != 0)
                        {
                            if (nodeMatrix[i - 1, j] != null)
                            {
                                nodeMatrix[i, j].Top = nodeMatrix[i - 1, j];
                            }
                        }

                        // Set right node
                        if (j != this.width - 1)
                        {
                            if (nodeMatrix[i, j + 1] != null)
                            {
                                nodeMatrix[i, j].Right = nodeMatrix[i, j + 1];
                            }
                        }

                        // Set bottom node
                        if (i != this.depth - 1)
                        {
                            if (nodeMatrix[i + 1, j] != null)
                            {
                                nodeMatrix[i, j].Bottom = nodeMatrix[i + 1, j];
                            }
                        }

                        // Isolation validation
                        if (nodeMatrix[i,j].Type == "Treasure")
                        {
                            if (!nodeMatrix[i,j].IsExplorable())
                            {
                                throw new Exception("Treasure must be accessible");
                            }
                        }
                        else if (nodeMatrix[i,j].Type == "Krusty Krab")
                        {
                            if (!nodeMatrix[i,j].IsExplorable())
                            {
                                throw new Exception("Krusty Krab cannot be isolated");
                            }
                        }
                    }
                }
            }

            // 3. Display matrix
            for(int i = 0; i < this.depth; i++)
            {
                for(int j = 0; j < this.width; j++)
                {
                    if (nodeMatrix[i,j] != null)
                    {
                        Console.Write(nodeMatrix[i, j].Type + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
