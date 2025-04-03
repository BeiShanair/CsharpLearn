namespace S2_14
{
    internal class Program
    {
        static void InitConsole(int w, int h)
        {
            Console.CursorVisible = false;
            
            Console.SetWindowSize(w, h);
            Console.SetBufferSize(w, h);

        }
        enum EScreenId
        {
            Begin,
            Game,
            End
        }

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

        static void GameScreen(int w, int h)
        {
            DrawWall(w, h);
            while (true)
            {

            }
        }
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
            Console.SetCursorPosition(2, h - 9);
            Console.Write("∥：暂停，一回合不动");
            Console.SetCursorPosition(26, h - 9);
            Console.Write("●：炸弹，倒退五格");
            Console.SetCursorPosition(2, h - 8);
            Console.Write("⩉：时空隧道，随机倒退、暂停、换位置");

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
