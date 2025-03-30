namespace S2_1
{
    // 枚举
    // 枚举是一种数据类型，用于定义一组命名常量（其值为整型），一般用来表示状态、类型等等

    // 枚举的声明
    // 使用enum关键字来声明枚举类型，枚举类型名一般使用大写字母E开头
    // 枚举的成员默认从0开始，依次递增
    enum EColor
    {
        BLACK, // 其值为0
        RED, // 其值为1
        GREEN = 10, // 其值为10
        BLUE // 其值为11（在上一个基础上累加）
    }
    // 枚举一般在namespace中声明，也可在类和结构体中声明
    // 但不能在函数中声明

    internal class Program
    {
        static void Main(string[] args)
        {
            // 枚举

            // 声明枚举变量
            // 自定义枚举类型 变量名字 = 自定义枚举类型.枚举成员
            EColor color = EColor.RED;
            switch (color)
            {
                case EColor.BLACK:
                    Console.WriteLine("黑色");
                    break;
                case EColor.RED:
                    Console.WriteLine("红色");
                    break;
                case EColor.GREEN:
                    Console.WriteLine("绿色");
                    break;
                case EColor.BLUE:
                    Console.WriteLine("蓝色");
                    break;
            }


            // 枚举的类型转换（int）
            int i = (int)EColor.RED;
            Console.WriteLine(i);

            // 枚举的类型转换（string）
            string s = EColor.RED.ToString();
            Console.WriteLine(s); // 输出：RED

            // string转换为枚举
            // （目标枚举类型）Enum.Parse(typeof(目标枚举类型), "枚举成员")
            EColor color2 = (EColor)Enum.Parse(typeof(EColor), "GREEN");
            Console.WriteLine(color2); // 输出：GREEN
        }
    }
}
