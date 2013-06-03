using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_18___MaximumPathSum1
{
    class NodeCollection
    {
        public int X;
        public int Y;
        public int Value;
        NodeCollection leftChild;
        NodeCollection rightChild;

        public NodeCollection(int x, int y, int value)
        {
            this.X = x;
            this.Y = y;
            this.Value = value;
        }

        public void Add(NodeCollection node)
        {
            if (node.X == this.X - 1 && node.Y == this.Y + 1)
                leftChild = node;
            else if (node.X == this.X + 1 && node.Y == this.Y + 1)
                rightChild = node;
            else if (node.Y > this.Y)
            {
                if (leftChild != null)
                    leftChild.Add(node);
                if (rightChild != null)
                    rightChild.Add(node);
            }
        }

        public override string ToString()
        {
            return "Point " + X + ", " + Y + " Value " + Value;
        }

        public int PathValue
        {
            get
            {
                int leftPathValue = 0;
                int rightPathValue = 0;
                if (leftChild != null)
                    leftPathValue = leftChild.PathValue;
                if (rightChild != null)
                    rightPathValue = rightChild.PathValue;

                if (leftPathValue > rightPathValue)
                    return leftPathValue + Value;
                else
                    return rightPathValue + Value;

            }
        }
    }
}
