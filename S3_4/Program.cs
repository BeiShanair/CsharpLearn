namespace S3_4
{
    // 万物之父
    // object
    // object是所有类的基类
    class Father
    {

    }
    class Son : Father
    {

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Son son = new Son();
            if (son is Father)
            {
                Console.WriteLine("son是Father的子类");

            }
            object o = son;

            // 装箱和拆箱
            // 装箱：将值类型转换为引用类型
            // 拆箱：将引用类型转换为值类型
            int a = 10;
            object o1 = a; // 装箱
            int b = (int)o1; // 拆箱
        }
    }
}
