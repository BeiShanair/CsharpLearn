namespace S2_6
{
    internal class Program
    {
        // 函数
        // 作用：封装代码，提高代码复用性，抽象

        // 函数的定义
        // 在class或struct中定义

        // 基本语法
        // 访问修饰符 返回值类型 函数名(参数列表)
        // {
        //     函数体
        //     return 返回值;
        // }
        static int Add(int a, int b)
        {
            return a + b;
        }

        // 返回void：无返回值（也可以选择性地写return）

        // 函数的类型：
        // 1. 无参数无返回值
        // 2. 有参数无返回值
        // 3. 无参数有返回值
        // 4. 有参数有返回值

        static void Print()
        {
            Console.WriteLine("Hello World!");
        }

        static void Main(string[] args)
        {
            // 函数的调用
            // 函数名(参数列表)
            int result = Add(1, 2);
            Console.WriteLine(result);

            Print();
        }
    }
}
