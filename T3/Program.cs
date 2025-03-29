namespace T3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 控制台基础设置
            // 隐藏光标
            Console.CursorVisible = false;
            // 设置控制台大小
            int w = 50;
            int h = 30;
            Console.SetWindowSize(w, h);
            Console.SetBufferSize(w, h);
            #endregion

            #region 游戏界面
            int nowId = 1;
            bool victory = false;
            while (true){
                switch (nowId)
                {
                    case 1:
                        #region 选择菜单
                        Console.Clear();
                        Console.SetCursorPosition(w / 2 - 2, 8);
                        Console.Write("给木");

                        int nowSelectId = 0;

                        while (true)
                        {
                            // isQuitWhile用于判断是否退出当前while循环
                            bool isQuitWhile = false;

                            // 根据选择的编号设置对应选项的颜色
                            Console.ForegroundColor = 
                                nowSelectId == 0 ? ConsoleColor.Red : ConsoleColor.White;
                            
                            // 设置“开始游戏”
                            Console.SetCursorPosition(w / 2 - 4, 10);
                            Console.Write("开始游戏");

                            Console.ForegroundColor =
                                nowSelectId == 1 ? ConsoleColor.Red : ConsoleColor.White;

                            // 设置“退出游戏”
                            Console.SetCursorPosition(w / 2 - 4, 12);
                            Console.Write("退出游戏");

                            // 获取用户输入
                            char input = Console.ReadKey(true).KeyChar;
                            // 根据用户输入进行判断
                            switch (input)
                            {
                                case 'w':
                                case 'W':
                                    nowSelectId--;
                                    if (nowSelectId < 0)
                                    {
                                        nowSelectId = 0;
                                    }
                                    break;
                                case 's':
                                case 'S':
                                    nowSelectId++;
                                    if (nowSelectId > 1)
                                    {
                                        nowSelectId = 1;
                                    }
                                    break;
                                // 用户选择J则进行该选项
                                case 'j':
                                case 'J':
                                    if (nowSelectId == 0)
                                    {
                                        nowId = 2;
                                        isQuitWhile = true;
                                    }
                                    else
                                    {
                                        Environment.Exit(0);
                                    }
                                    break;
                            }
                             if (isQuitWhile)
                            {
                                break;
                            }
                        }
                        break;
                    #endregion
                    case 2:
                        #region 游戏场景
                        Console.Clear();

                        #region 画边界墙
                        Console.ForegroundColor = ConsoleColor.Red;
                        // 三道横墙
                        for (int i = 0; i < w; i+=2)
                        {
                            Console.SetCursorPosition(i, 0);
                            Console.Write("■");

                            Console.SetCursorPosition(i, h - 6);
                            Console.Write("■");

                            Console.SetCursorPosition(i, h - 1);
                            Console.Write("■");
                        }
                        // 两道竖墙
                        for (int i = 0; i < h; i++)
                        {
                            Console.SetCursorPosition(0, i);
                            Console.Write("■");

                            Console.SetCursorPosition(w - 2, i);
                            Console.Write("■");
                        }
                        #endregion

                        #region boss属性
                        Random r = new Random();
                        int bossX = 24;
                        int bossY = 15;
                        int bossHp = 100;
                        int bossAttackMin = 7;
                        int bossAttackMax = 13;
                        string bossId = "■";
                        ConsoleColor bossColor = ConsoleColor.Green;
                        #endregion

                        #region 玩家属性
                        int playerX = 4;
                        int playerY = 5;
                        int playerHp = 100;
                        int playerAttackMin = 8;
                        int playerAttackMax = 13;
                        string playerId = "●";
                        ConsoleColor playerColor = ConsoleColor.Yellow;
                        #endregion

                        int pX = 24;
                        int pY = 5;

                        char input2;
                        bool isPlayerMovable = true;
                        bool isOver = false;
                        while (true)
                        {
                            if (bossHp > 0)
                            {
                                // 画Boss
                                Console.ForegroundColor = bossColor;
                                Console.SetCursorPosition(bossX, bossY);
                                Console.Write(bossId);
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.SetCursorPosition(pX, pY);
                                Console.Write("■");
                            }
                                // 画玩家
                                Console.ForegroundColor = playerColor;
                            Console.SetCursorPosition(playerX, playerY);
                            Console.Write(playerId);

                            #region 玩家移动
                            input2 = Console.ReadKey(true).KeyChar;
                            Console.SetCursorPosition(playerX, playerY);
                            Console.Write(" ");

                            if (isPlayerMovable)
                            {
                                switch (input2)
                                {
                                    case 'w':
                                    case 'W':
                                        playerY--;
                                        if (playerY < 1)
                                        {
                                            playerY = 1;
                                        }
                                        if (playerX == bossX && playerY == bossY && bossHp > 0 ||
                                            playerX == pX && playerY == pY && bossHp <= 0)
                                        {
                                            playerY++;
                                        }
                                        break;
                                    case 's':
                                    case 'S':
                                        playerY++;
                                        if (playerY > h - 7)
                                        {
                                            playerY = h - 7;
                                        }
                                        if (playerX == bossX && playerY == bossY && bossHp > 0 ||
                                            playerX == pX && playerY == pY && bossHp <= 0)
                                        {
                                            playerY--;
                                        }
                                        break;
                                    case 'a':
                                    case 'A':
                                        playerX -= 2;
                                        if (playerX < 2)
                                        {
                                            playerX = 2;
                                            }
                                        if (playerX == bossX && playerY == bossY && bossHp > 0 ||
                                            playerX == pX && playerY == pY && bossHp <= 0)
                                        {
                                            playerX += 2;
                                        }
                                        break;
                                    case 'd':
                                    case 'D':
                                        playerX += 2;
                                        if (playerX > w - 4)
                                        {
                                            playerX = w - 4;
                                        }
                                        if (playerX == bossX && playerY == bossY && bossHp > 0 ||
                                            playerX == pX && playerY == pY && bossHp <= 0)
                                        {
                                            playerX -= 2;
                                        }
                                        
                                        break;
                                    case 'j':
                                    case 'J':
                                        if (bossHp > 0)
                                        {
                                            if (playerX == bossX && playerY == bossY - 1 ||
                                            playerX == bossX && playerY == bossY + 1 ||
                                            playerX == bossX - 2 && playerY == bossY ||
                                            playerX == bossX + 2 && playerY == bossY)
                                            {
                                                isPlayerMovable = false;
                                                Console.SetCursorPosition(2, h - 5);
                                                Console.ForegroundColor = ConsoleColor.White;
                                                Console.Write("按J攻击Boss");
                                                Console.SetCursorPosition(2, h - 4);
                                                Console.Write("玩家血量：" + playerHp);
                                                Console.SetCursorPosition(2, h - 3);
                                                Console.Write("Boss血量：" + bossHp);
                                            }
                                        }
                                        else if (playerX == pX && playerY == pY - 1 ||
                                            playerX == pX && playerY == pY + 1 ||
                                            playerX == pX - 2 && playerY == pY ||
                                            playerX == pX + 2 && playerY == pY)
                                        {
                                            nowId = 3;
                                            isOver = true;
                                        }
                                        break;
                                }
                                if (isOver)
                                {
                                    break;
                                }
                            }
                            else
                            {
                                if (input2 == 'J' || input2 == 'j')
                                {
                                    if (bossHp <= 0)
                                    {
                                        Console.SetCursorPosition(bossX, bossY);
                                        Console.Write(" ");
                                        isPlayerMovable = true;
                                        victory = true;
                                    }
                                    else if (playerHp <= 0)
                                    {
                                        // 玩家死亡，游戏结束
                                        nowId = 3;
                                        break;
                                    }
                                    else
                                    {
                                        // 玩家攻击Boss
                                        int playerAttack = r.Next(playerAttackMin, playerAttackMax);
                                        int bossAttack = r.Next(bossAttackMin, bossAttackMax);
                                        bossHp -= playerAttack;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(2, h - 4);
                                        Console.Write("                                       ");
                                        Console.SetCursorPosition(2, h - 4);
                                        Console.Write("你对boss造成了{0}伤害，boss剩余血量为{1}", playerAttack, bossHp);

                                        // Boss攻击玩家
                                        if (bossHp > 0)
                                        {
                                            playerHp -= bossAttack;
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            Console.SetCursorPosition(2, h - 3);
                                            Console.Write("                                       ");
                                            Console.SetCursorPosition(2, h - 3);
                                            Console.Write("boss对你造成了{0}伤害，玩家剩余血量为{1}", bossAttack, playerHp);

                                            if (playerHp <= 0)
                                            {
                                                Console.SetCursorPosition(2, h - 5);
                                                Console.Write("                                       ");
                                                Console.SetCursorPosition(2, h - 4);
                                                Console.Write("                                       ");
                                                Console.SetCursorPosition(2, h - 3);
                                                Console.Write("                                       ");
                                                Console.SetCursorPosition(2, h - 5);
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                Console.Write("战斗失败");
                                                Console.SetCursorPosition(2, h - 4);
                                                Console.Write("按J键继续");
                                            }
                                        }
                                        else
                                        {
                                            Console.SetCursorPosition(2, h - 5);
                                            Console.Write("                                       ");
                                            Console.SetCursorPosition(2, h - 4);
                                            Console.Write("                                       ");
                                            Console.SetCursorPosition(2, h - 3);
                                            Console.Write("                                       ");
                                            Console.SetCursorPosition(2, h - 5);
                                            Console.Write("恭喜战胜boss");
                                            Console.SetCursorPosition(2, h - 4);
                                            Console.Write("按J键去获取宝箱");
                                        }
                                    }
                                }
                            }
                            #endregion
                        }
                        break;
                        #endregion
                    case 3:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.SetCursorPosition(w / 2 - 4, 5);
                        Console.Write("Game Over");

                        if (victory)
                        {
                            Console.SetCursorPosition(w / 2 - 1, 6);
                            Console.Write("Victory");
                        }
                        else
                        {
                            Console.SetCursorPosition(w / 2 - 4, 6);
                            Console.Write("Failure");
                        }
                        int nowSelectId2 = 0;
                        while (true)
                        {
                            bool isQuitWhile2 = false;

                            // 根据选择的编号设置对应选项的颜色
                            Console.ForegroundColor =
                                nowSelectId2 == 0 ? ConsoleColor.Red : ConsoleColor.White;

                            // 设置“开始游戏”
                            Console.SetCursorPosition(w / 2 - 6, 10);
                            Console.Write("回到开始界面");

                            Console.ForegroundColor =
                                nowSelectId2 == 1 ? ConsoleColor.Red : ConsoleColor.White;

                            // 设置“退出游戏”
                            Console.SetCursorPosition(w / 2 - 4, 12);
                            Console.Write("退出游戏");

                            // 获取用户输入
                            char input = Console.ReadKey(true).KeyChar;
                            // 根据用户输入进行判断
                            switch (input)
                            {
                                case 'w':
                                case 'W':
                                    nowSelectId2--;
                                    if (nowSelectId2 < 0)
                                    {
                                        nowSelectId2 = 0;
                                    }
                                    break;
                                case 's':
                                case 'S':
                                    nowSelectId2++;
                                    if (nowSelectId2 > 1)
                                    {
                                        nowSelectId2 = 1;
                                    }
                                    break;
                                // 用户选择J则进行该选项
                                case 'j':
                                case 'J':
                                    if (nowSelectId2 == 0)
                                    {
                                        nowId = 1;
                                        isQuitWhile2 = true;
                                    }
                                    else
                                    {
                                        Environment.Exit(0);
                                    }
                                    break;
                            }
                            if (isQuitWhile2)
                            {
                                break;
                            }
                    }
                        break;
                }
            }
            #endregion
        }
    }
}
