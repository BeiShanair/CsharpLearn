namespace S2_9
{
    internal class Program
    {
        // 函数重载
        // 函数名相同，参数列表不同（参数类型、参数个数、参数顺序）
        static int Calculate(int a, int b)
        {
            return a + b;
        }
        static int Calculate(int a, int b, int c)
        {
            return a + b;
        }
        static double Calculate(double a, double b)
        {
            return a + b;
        }
        static double Calculate(int a, double b)
        {
            return a + b;
        }

        static void Main(string[] args)
        {
            int a = 1, b = 2 , c = 3;
            Console.WriteLine(Calculate(a, b));
            Console.WriteLine(Calculate(a, b, c));

            double d1 = 1.1, d2 = 2.2;
            Console.WriteLine(Calculate(d1, d2));
            Console.WriteLine(Calculate(a, d2));
        }
    }
}
