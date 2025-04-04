namespace S2_14
{
    internal class Program
    {
        // 初始化控制台
        static void InitConsole(int w, int h)
        {
            Console.CursorVisible = false;
            
            Console.SetWindowSize(w, h);
            Console.SetBufferSize(w, h);

        }

        // 当前选择屏幕类型
        enum EScreenId
        {
            Begin,
            Game,
            End
        }

        // 格子类型
        enum ECellType
        {
            Normal,
            Boom,
            Pause,
            Tunnel
        }

        // 位置信息结构体
         struct Vector2
        {
            public int x;
            public int y;
            public Vector2(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }

        // 格子结构体
        struct Cell
        {
            public ECellType type;
            public Vector2 pos;
            public Cell(ECellType type, int x, int y)
            {
                this.type = type;
                this.pos.x = x;
                this.pos.y = y;
            }

            public void Draw()
            {
                Console.SetCursorPosition(pos.x, pos.y);
                switch (type)
                {
                    case ECellType.Normal:
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("□");
                        break;
                    case ECellType.Boom:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("●");
                        break;
                    case ECellType.Pause:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("∥");
                        break;
                    case ECellType.Tunnel:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("⩉");
                        break;
                }
            }
        }

        // 开始场景
        static void BeginScreen(int w, int h, ref EScreenId n)
        {
            Console.SetCursorPosition(w / 2 - 2, 5);
            Console.Write("给木");
            int selectId = 0;
            bool start = false;
            while (true)
            {
                Console.ForegroundColor = selectId == 0 ? ConsoleColor.Red : ConsoleColor.White;
                Console.SetCursorPosition(w / 2 - 4, 10);
                Console.Write("开始游戏");
                Console.ForegroundColor = selectId == 1 ? ConsoleColor.Red : ConsoleColor.White;
                Console.SetCursorPosition(w / 2 - 4, 15);
                Console.Write("退出游戏");
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.W:
                        selectId--;
                        if (selectId < 0)
                        {
                            selectId = 0;
                        }
                        break;
                    case ConsoleKey.S:
                        selectId++;
                        if (selectId > 1)
                        {
                            selectId = 1;
                        }
                        break;
                    case ConsoleKey.J:
                        if (selectId == 0)
                        {
                            n = EScreenId.Game;
                            start = true;
                        }
                        else
                        {
                            Environment.Exit(0);
                        }
                        break;
                }
                if (start)
                {
                    break;
                }
            }
        }

        // 游戏场景
        static void GameScreen(int w, int h)
        {
            DrawWall(w, h);
            while (true)
            {

            }
        }

        // 绘制边界墙
        static void DrawWall(int w, int h)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            for (int i = 0; i < w; i+=2)
            {
                Console.SetCursorPosition(i, 0);
                Console.Write("■");
                Console.SetCursorPosition(i, h - 1);
                Console.Write("■");
                Console.SetCursorPosition(i, h - 6);
                Console.Write("■");
                Console.SetCursorPosition(i, h - 11);
                Console.Write("■");
            }
            for (int i = 0; i < h; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write("■");
                Console.SetCursorPosition(w - 2, i);
                Console.Write("■");
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(2, h - 10);
            Console.Write("□：普通格子");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition(2, h - 9);
            Console.Write("∥：暂停，一回合不动");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(26, h - 9);
            Console.Write("●：炸弹，倒退五格");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(2, h - 8);
            Console.Write("⩉：时空隧道，随机倒退、暂停、换位置");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetCursorPosition(2, h - 7);
            Console.Write("◆：玩家");

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.SetCursorPosition(12, h - 7);
            Console.Write("▲：电脑");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(22, h - 7);
            Console.Write("○：玩家和电脑重合");

            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(2, h - 5);
            Console.Write("按任意键开始游戏");
        }

        static void Main(string[] args)
        {
            int width = 50;
            int height = 30;
            InitConsole(width, height);

            EScreenId nowScreenId = EScreenId.Begin;
            while (true)
            {
                switch (nowScreenId)
                {
                    case EScreenId.Begin:
                        Console.Clear();
                        BeginScreen(width, height, ref nowScreenId);
                        break;
                    case EScreenId.Game:
                        Console.Clear();
                        GameScreen(width, height);
                        break;
                    case EScreenId.End:
                        Console.Clear();
                        break;
                }
            }
        }
    }
}
