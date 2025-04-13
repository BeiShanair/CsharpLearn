using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S3_15
{
    struct Position
    {
        public int x;
        public int y;

        public Position(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        
        public static bool operator !=(Position a, Position b)
        {
            return !(a.x == b.x && a.y == b.y);
        }

        public static bool operator ==(Position a, Position b)
        {
            return a.x == b.x && a.y == b.y;
        }
    }
}
