namespace T1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 控制台其他内容
            char c = Console.ReadKey(true).KeyChar; // 获取用户输入的字符，不显示在控制台上
            Console.WriteLine("用户输入的字符是：" + c); // 输出用户输入的字符

            // 清空控制台
            Console.Clear();

            // 设置控制台大小
            Console.SetWindowSize(100, 50);

            // 设置缓冲区大小
            Console.SetBufferSize(1000, 1000);

            // 设置光标位置
            // 左上角坐标为(0,0)，向右为X轴正方向，向下为Y轴正方向
            Console.SetCursorPosition(10, 5); // 注意，在视觉上，1y = 2x
            Console.WriteLine("Hello, World!");

            // 设置颜色
            // 文字颜色
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Hello, World!");

            // 背景颜色
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("Hello, World!");
            // 设置背景颜色之后，需要clear一次，才能看到效果
            Console.Clear();

            // 光标显隐
            Console.CursorVisible = false; // 隐藏光标

            // 关闭控制台
            Environment.Exit(0);
        }
    }
}
