namespace T11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Clear();
            
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.CursorVisible = false;

            int x = 0;
            int y = 0;

            while (true)
            {
                Console.SetCursorPosition(x, y);
                Console.Write("■");

                // 得到玩家的输入信息
                char c = Console.ReadKey(true).KeyChar;
                // 把之前的方块擦除
                Console.SetCursorPosition(x, y);
                Console.Write(" ");
                switch (c)
                {
                    case 'w':
                    case 'W':
                        y -= 1;
                        if (y < 0)
                        {
                            y = 0;
                        }
                        break;
                    case 's':
                    case 'S':
                        y += 1;
                        if (y > Console.BufferHeight - 1)
                        {
                            y = Console.BufferHeight - 1;
                        }
                        break;
                    case 'a':
                    case 'A':
                        x -= 1;
                        if (x < 0)
                        {
                            x = 0;
                        }
                        break;
                    case 'd':
                    case 'D':
                        x += 1;
                        if (x > Console.BufferWidth - 1)
                        {
                            x = Console.BufferWidth - 1;
                        }
                        break;
                }
            }
        }
    }
}
