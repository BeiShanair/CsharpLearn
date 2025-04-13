using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S3_15
{
    abstract class BeginOrAnd : ISceneUpdate
    {
        protected int nowSelectId = 0;
        protected string strTitle;
        protected string strOne;

        public abstract void EnterJDoSomething();

        public void Update()
        {
            Console.ForegroundColor = ConsoleColor.White;

            Console.SetCursorPosition(Game.width / 2 - strTitle.Length, 5);
            Console.Write(strTitle);

            Console.SetCursorPosition(Game.width / 2 - strOne.Length, 8);
            Console.ForegroundColor = nowSelectId == 0 ? ConsoleColor.Red : ConsoleColor.White;
            Console.Write(strOne);

            Console.SetCursorPosition(Game.width / 2 - 4, 10);
            Console.ForegroundColor = nowSelectId == 1 ? ConsoleColor.Red : ConsoleColor.White;
            Console.Write("结束游戏");

            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.W:
                    --nowSelectId;
                    if (nowSelectId < 0)
                    {
                        nowSelectId = 0;
                    }
                    break;
                case ConsoleKey.S:
                    ++nowSelectId;
                    if (nowSelectId > 1)
                    {
                        nowSelectId = 1;
                    }
                    break;
                case ConsoleKey.J:
                    EnterJDoSomething();
                    break;
            }
        }
    }
}
