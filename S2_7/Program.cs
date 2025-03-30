namespace S2_7
{
    internal class Program
    {
        static void ChangeValue(ref int value)
        {
            value = 3;
        }

        static void ChangeValue2(out int value)
        {
            value = 7;
        }

        static void Main(string[] args)
        {
            // ref和out，它们是函数参数的修饰符
            // 相当于全局变量

            int a = 1;
            ChangeValue(ref a);
            Console.WriteLine(a);

            int b = 5;
            ChangeValue2(out b);
            Console.WriteLine(b);

            //ref和out的区别
            //ref必须先初始化，out不需要
            //out传入的参数，在函数内部必须被赋值
        }
    }
}
