namespace S2_10
{
    internal class Program
    {
        // 递归函数
        // 必须有结束调用条件，否则会陷入无限循环
        // 斐波那契数列
        static int Fibonacci(int n)
        {
            if (n == 1 || n == 2)
            {
                return 1;
            }
            else
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
        }
        static void Main(string[] args)
        {
            int a = Fibonacci(10);
            Console.WriteLine(a);
        }
    }
}
