namespace S3_5
{
    // 密封类
    // 让类不能被继承
    // 语法：sealed class 类名
    sealed class Father
    {

    }
    // class Son : Father // 会报错
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
