using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Prombel_15___LatticePaths
{
    class PointComparable : IComparable<PointComparable>
    {
        public int X;
        public int Y;

        public PointComparable(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public int CompareTo(PointComparable other)
        {
            if (this.X > other.X)
                return 1;
            else if (this.X == other.X)
            {
                if (this.Y > other.Y)
                    return 1;
                else if (this.Y == other.Y)
                    return 0;
                else
                    return -1;
            }
            else
                return -1;
        }
    }
}
