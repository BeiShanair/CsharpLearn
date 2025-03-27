namespace LS10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // while 语句
            int i = 0;
            while (i < 10)
            {
                Console.WriteLine(i);
                i++;
            }

            // break 跳出循环
            while (true)
            {
                Console.WriteLine("请输入一个数字：");
                string input = Console.ReadLine();
                if (input == "1")
                {
                    break;
                }
            }

            // continue 跳过本次循环
            int a = 0;
            while (a <= 20)
            {
                if (a % 2 == 0)
                {
                    a++;
                    continue;
                }
                Console.WriteLine(a);
                a++;
            }

            // do while 语句
            // 先执行一次循环体，再判断条件
            int b = 0;
            do
            {
                Console.WriteLine(b);
                b++;
            }while (b <= 10);

            // for 语句
            for (int c = 0; c < 10; c++)
            {
                Console.WriteLine(c);
            }
        }
    }
}
