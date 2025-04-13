using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S3_15
{
    abstract class GameObject : IDraw
    {
        public Position pos;
        public abstract void Draw();
    }
}
