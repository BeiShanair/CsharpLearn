namespace LS5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 转义字符
            Console.WriteLine("换行符\n换行");
            Console.WriteLine("制表符\t123");
            Console.WriteLine("斜杠\\123");
            Console.WriteLine("\"双引号\"");
            Console.WriteLine("\'单引号\'");
            Console.WriteLine("光标退格123\b123");
            Console.WriteLine("空字符\0123");
            Console.WriteLine("警报音\a");

            // 取消转义字符
            Console.WriteLine(@"\123");
        }
    }
}
