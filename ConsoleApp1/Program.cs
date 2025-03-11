// 命名空间引用
using System;

// 命名空间定义（解决方案的名字）
namespace ConsoleApp1
{
    // 类定义（类名）
    class Program
    {
        // Main方法
        static void Main(string[] args)
        {
            // 打印Hello, World!（并自动空行）
            Console.WriteLine("Hello, World!");
            // 打印Hello（不自动空行）
            Console.Write("Hello");
            // 获取输入
            Console.ReadLine();
            Console.WriteLine("输入完毕");
            // 获取输入（这个是按任意键就继续执行）
            Console.ReadKey();
            Console.WriteLine("按了任意键");
        }
    }
}

