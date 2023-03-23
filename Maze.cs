using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Amazeing
{
    public class Maze
    {
        // === ATTRIBUTES ======================================================================
        private string sourceFile;
        private char[,] matrix;
        private int depth;
        private int width;

        // === CONSTRUCTOR =====================================================================
        public Maze()
        {
            this.sourceFile = "";
            this.depth = 0;
            this.width = 0;
        }

        // === GETTER SETTER ===================================================================
       public string SourceFile
        {
            get { return this.sourceFile; }
            set { this.sourceFile = value; }
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

        // === METHODS =========================================================================

        public void validate()
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

            // 5. Display matrix
            Console.WriteLine(this.depth);
            Console.WriteLine(this.width);
            for (int i = 0; i < this.depth; i++)
            {
                for(int j = 0; j < this.width; j++)
                {
                    Console.Write(this.matrix[i, j]);
                }
                Console.WriteLine();
            }
        }

    }
}
