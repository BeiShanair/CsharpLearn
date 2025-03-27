namespace LS9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // if条件语句
            // if (条件表达式或bool类型)
            // {
            //     // 条件为真时执行的代码
            // }
            if (true)
            {
                Console.WriteLine("条件为真");
            }

            // if else条件语句
            int a = 1;
            if (a > 5)
            {
                Console.WriteLine("a大于5");
            }
            else
            {
                Console.WriteLine("a小于等于5");
            }

            // if...else if...else条件语句
            if (a > 5)
            {
                Console.WriteLine("a大于5");
            }
            else if (a == 5)
            {
                Console.WriteLine("a等于5");
            }
            else
            {
                Console.WriteLine("a小于5");
            }

            // switch条件语句
            // switch 只能判断固定的值
            // 和 C++ 一样，这里的switch语句也是要写break的，不然就会贯穿
            a = 100;
            switch (a)
            {
                case 1:
                    Console.WriteLine("a等于1");
                    break;
                case 2:
                    Console.WriteLine("a等于2");
                    break;
                default: // default可以省略
                    Console.WriteLine("a不等于1也不等于2");
                    break;
            }
        }
    }
}
