using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazeing
{
    public class Dfs : Algorithm
    {
        // === ATTRIBUTES ======================================================================
        private Node[] nodeStack;

        // === CONSTRUCTOR =====================================================================
        public Dfs() : base("DFS") { }

        // === METHODS =========================================================================
        public void Push(Node newNode)
        {
            for (int i = 0; i < 100; i++)
            {
                if (this.nodeStack[i] == null)
                {
                    this.nodeStack[i] = newNode;
                    break;
                }
            }
        }

        public void Pop()
        {
            for (int i = 0; i < 100; i++)
            {
                if (this.nodeStack[i] == null)
                {
                    this.nodeStack[i - 1] = null;
                    break;
                }
            }
        }

        public Node GetTop()
        {
            for (int i = 0; i < 100; i++)
            {
                if (this.nodeStack[i] == null)
                {
                    return this.nodeStack[i - 1];
                }
            }
            return null;
        }

        public override Solution Use(Solution solution)
        {
            Solution newSolution = solution;
            return newSolution;
        }
    }
}
