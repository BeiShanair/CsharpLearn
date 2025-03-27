namespace T2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 随机数
            Random random = new Random();

            int i = random.Next(); // 生成一个非负的随机数
            Console.WriteLine(i);

            i = random.Next(100); // 生成一个0到99之间的随机数
            Console.WriteLine(i);
        }
    }
}
