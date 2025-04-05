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

        // 地图结构体
        struct Map
        {
            public Cell[] cell;

            public Map(int x, int y, int num)
            {
                cell = new Cell[num];
                int countX = 0;
                int countY = 0;
                int stepNum = 2;
                Random random = new Random();
                int randomNum;

                for (int i = 0; i < num; i++)
                {
                    randomNum = random.Next(0, 101);
                    // 初始化格子类型
                    if (randomNum < 85 || i == 0 || i == num - 1)
                    {
                        cell[i].type = ECellType.Normal;
                    }
                    else if (randomNum >= 85 && randomNum < 90)
                    {
                        cell[i].type = ECellType.Boom;
                    }
                    else if (randomNum >= 90 && randomNum < 95)
                    {
                        cell[i].type = ECellType.Pause;
                    }
                    else
                    {
                        cell[i].type = ECellType.Tunnel;
                    }
                    cell[i].pos = new Vector2(x, y);
                    if (countX == 10)
                    {
                        y += 1;
                        countY++;
                        if (countY == 2)
                        {
                            countY = 0;
                            countX = 0;
                            stepNum = -stepNum;
                        }
                    }
                    else
                    {
                        x += stepNum;
                        countX++;
                    }
                        
                }

            }

            public void Draw()
            {
                for (int i = 0; i < cell.Length; i++)
                {
                    cell[i].Draw();
                }
            }
        }

        // 玩家枚举
        enum EPlayer
        {
            Player,
            Computer
        }

        // 玩家结构体
        struct Player
        {
            public EPlayer player;
            public int nowIndex;
            public bool isPause;

            public Player(EPlayer player, int nowIndex)
            {
                this.player = player;
                this.nowIndex = nowIndex;
                isPause = false;
            }

            public void Draw(Map map)
            {
                Cell cell = map.cell[nowIndex];
                Console.SetCursorPosition(cell.pos.x, cell.pos.y);
                switch (player)
                {
                    case EPlayer.Player:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("◆");
                        break;
                    case EPlayer.Computer:
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.Write("▲");
                        break;
                }
            }
        }

        // 绘制边界墙
        static void DrawWall(int w, int h)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            for (int i = 0; i < w; i += 2)
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

        // 绘制玩家
        static void DrawPlayer(Player player, Player computer, Map map)
        {
            if (player.nowIndex == computer.nowIndex)
            {
                Cell cell = map.cell[player.nowIndex];
                Console.SetCursorPosition(cell.pos.x, cell.pos.y);
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("○");
            }
            else
            {
                player.Draw(map);
                computer.Draw(map);
            }
        }

        // 清除信息
        static void CleanInfo(int h)
        {
            Console.SetCursorPosition(2, h - 5);
            Console.Write("                               ");
            Console.SetCursorPosition(2, h - 4);
            Console.Write("                               ");
            Console.SetCursorPosition(2, h - 3);
            Console.Write("                               ");
            Console.SetCursorPosition(2, h - 2);
            Console.Write("                               ");
        }

        // 扔骰子
        static bool ThrowDice(int w, int h, ref Player player, ref Player computer, Map map)
        {
            CleanInfo(h);

            Console.ForegroundColor = player.player == EPlayer.Player ? ConsoleColor.Cyan : ConsoleColor.Magenta;

            if (player.isPause)
            {
                Console.SetCursorPosition(2, h - 5);
                Console.Write("{0}处于暂停状态，按任意键继续", player.player == EPlayer.Player ? "你" : "电脑");
                player.isPause = false;
                return false;
            }

            Random r = new Random();
            int random = r.Next(0, 7);
            player.nowIndex += random;

            Console.SetCursorPosition(2, h - 5);
            Console.Write("{0}扔出的点数为：{1}", player.player == EPlayer.Player ? "你" : "电脑", random);

            if (player.nowIndex >= map.cell.Length - 1)
            {
                player.nowIndex = map.cell.Length - 1;
                Console.SetCursorPosition(2, h - 4);
                if (player.player == EPlayer.Player)
                {
                    Console.Write("恭喜你率先到达终点！你赢了！");
                }
                else
                {
                    Console.Write("很遗憾，电脑率先到达终点！你输了！");
                }
                Console.SetCursorPosition(2, h - 3);
                Console.Write("按任意键结束游戏");
                return true;
            }
            else
            {
                Cell cell = map.cell[player.nowIndex];
                switch (cell.type)
                {
                    case ECellType.Normal:
                        Console.SetCursorPosition(2, h - 4);
                        Console.Write("{0}到达了一个安全的位置", player.player == EPlayer.Player ? "你" : "电脑");
                        Console.SetCursorPosition(2, h - 3);
                        Console.Write("按任意键继续，让{0}扔骰子", player.player == EPlayer.Computer ? "你" : "电脑");
                        break;
                    case ECellType.Boom:
                        player.nowIndex -= 5;
                        if (player.nowIndex < 0)
                        {
                            player.nowIndex = 0;
                        }
                        Console.SetCursorPosition(2, h - 4);
                        Console.Write("{0}踩到了炸弹，退后5格", player.player == EPlayer.Player ? "你" : "电脑");
                        Console.SetCursorPosition(2, h - 3);
                        Console.Write("按任意键继续，让{0}扔骰子", player.player == EPlayer.Computer ? "你" : "电脑");
                        break;
                    case ECellType.Pause:
                        player.isPause = true;
                        Console.SetCursorPosition(2, h - 4);
                        Console.Write("{0}暂停一回合", player.player == EPlayer.Player ? "你" : "电脑");
                        Console.SetCursorPosition(2, h - 3);
                        Console.Write("按任意键继续，让{0}扔骰子", player.player == EPlayer.Computer ? "你" : "电脑");
                        break;
                    case ECellType.Tunnel:
                        Console.SetCursorPosition(2, h - 4);
                        Console.Write("{0}踩到了时空隧道", player.player == EPlayer.Player ? "你" : "电脑");
                        
                        random = r.Next(1, 91);
                        if (random < 30)
                        {
                            player.nowIndex -= 5;
                            if (player.nowIndex < 0)
                            {
                                player.nowIndex = 0;
                            }
                            Console.SetCursorPosition(2, h - 3);
                            Console.Write("触发炸弹，倒退5格");
                        }
                        else if (random <= 60)
                        {
                            player.isPause = true;
                            Console.SetCursorPosition(2, h - 3);
                            Console.Write("触发暂停，暂停一回合");
                        }
                        else
                        {
                            int temp = player.nowIndex;
                            player.nowIndex = computer.nowIndex;
                            computer.nowIndex = temp;
                            Console.SetCursorPosition(2, h - 3);
                            Console.Write("双方交换位置");
                        }
                        Console.SetCursorPosition(2, h - 2);
                        Console.Write("按任意键继续，让{0}扔骰子", player.player == EPlayer.Computer ? "你" : "电脑");
                        break;
                }
            }
                return false;
        }
        // 开始场景
        static void BeginScreen(int w, int h, ref EScreenId n)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(w / 2 - 2, 5);
            Console.Write(n == EScreenId.Begin ? "给木" : "结束");
            int selectId = 0;
            bool start = false;
            while (true)
            {
                Console.ForegroundColor = selectId == 0 ? ConsoleColor.Red : ConsoleColor.White;
                Console.SetCursorPosition(w / 2 - 4, 10);
                Console.Write(n == EScreenId.Begin ? "开始游戏" : "重新开始");
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
                            n = n == EScreenId.Begin ? EScreenId.Game : EScreenId.Begin;
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
        static void GameScreen(int w, int h, ref EScreenId screen)
        {
            DrawWall(w, h);

            Map map = new Map(14, 3, 80);
            map.Draw();

            Player player = new Player(EPlayer.Player, 0);
            Player computer = new Player(EPlayer.Computer, 0);
            DrawPlayer(player, computer, map);

            bool isGameOver = false;
            while (true)
            {
                Console.ReadKey(true);
                isGameOver = ThrowDice(w, h, ref player, ref computer, map);
                map.Draw();
                DrawPlayer(player, computer, map);
                if (isGameOver)
                {
                    Console.ReadKey(true);
                    screen = EScreenId.End;
                    break;
                }

                Console.ReadKey(true);
                isGameOver = ThrowDice(w, h, ref computer, ref player, map);
                map.Draw();
                DrawPlayer(player, computer, map);
                if (isGameOver)
                {
                    Console.ReadKey(true);
                    screen = EScreenId.End;
                    break;
                }
            }
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
                        GameScreen(width, height, ref nowScreenId);
                        break;
                    case EScreenId.End:
                        Console.Clear();
                        BeginScreen(width, height, ref nowScreenId);
                        break;
                }
            }
        }
    }
}
