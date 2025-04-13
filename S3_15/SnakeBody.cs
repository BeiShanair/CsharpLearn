using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S3_15
{
    enum EBodyType
    {
        Head,
        Body
    }
    class SnakeBody : GameObject
    {
        private EBodyType type;

        public SnakeBody(EBodyType type, int x, int y)
        {
            this.type = type;
            pos = new Position(x, y);
        }

        public override void Draw()
        {
            Console.SetCursorPosition(pos.x, pos.y);
            Console.ForegroundColor = type == EBodyType.Head ? ConsoleColor.Yellow : ConsoleColor.Green;
            Console.Write(type == EBodyType.Head ? "●" : "○");
        }
    }
}
