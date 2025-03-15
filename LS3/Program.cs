namespace LS3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("不同变量占用内存空间");

            Console.WriteLine("sbyte占用内存空间为：" + sizeof(sbyte));
            Console.WriteLine("int占用内存空间为：" + sizeof(int));
            Console.WriteLine("short占用内存空间为：" + sizeof(short));
            Console.WriteLine("long占用内存空间为：" + sizeof(long));

            Console.WriteLine("float占用内存空间为：" + sizeof(float));
            Console.WriteLine("double占用内存空间为：" + sizeof(double));
            Console.WriteLine("decimal占用内存空间为：" + sizeof(decimal));

            Console.WriteLine("byte占用内存空间为：" + sizeof(byte));
            Console.WriteLine("ushort占用内存空间为：" + sizeof(ushort));
            Console.WriteLine("ulong占用内存空间为：" + sizeof(ulong));

            Console.WriteLine("bool占用内存空间为：" + sizeof(bool));
            Console.WriteLine("char占用内存空间为：" + sizeof(char));
            // string没有固定的占用内存空间
        }
    }
}
