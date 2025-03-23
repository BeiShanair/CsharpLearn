namespace LS4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 常量
            // const 变量类型 变量名 = 值;
            const int months = 12;
            Console.WriteLine("一年有{0}个月", months);

            // 常量的特点
            // 1. 常量必须初始化
            // 2. 常量不能被修改

            // months = 13; // 错误，常量不能被修改
        }
    }
}
