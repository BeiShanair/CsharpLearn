namespace S2_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 值类型和引用类型
            // 引用类型：string、数组、类
            // 值类型：int、float、double、bool、char、struct（结构体）、enum

            // 使用上的区别
            int a = 10;
            int[] arr = { 1, 2, 3 };

            int b = a;
            int[] arr2 = arr;
            Console.WriteLine("a = {0},b = {1}", a, b);
            Console.WriteLine("arr[0] = {0},arr2[0] = {1}", arr[0], arr2[0]);

            b = 20;
            arr2[0] = 5;
            Console.WriteLine("a = {0},b = {1}", a, b); // a = 10,b = 20
            Console.WriteLine("arr[0] = {0},arr2[0] = {1}", arr[0], arr2[0]); // 都是5
        
            // 值类型是直接存储数据的，而引用类型是存储数据的引用（地址）
            // 值类型在栈上分配内存，引用类型在堆上分配内存
            // 栈由系统分配，小而快，堆由程序员分配，大而慢

            // 特殊引用类型string
            string str1 = "hello";
            string str2 = str1;
            Console.WriteLine("str1 = {0},str2 = {1}", str1, str2); // str1 = hello,str2 = hello
            str2 = "world";
            Console.WriteLine("str1 = {0},str2 = {1}", str1, str2); // str1 = hello,str2 = world
            // string非常特殊，由C#底层处理时，都会自动进行深拷贝，所以str2的修改不会影响str1
       
            //额外补充：通过debug，查看内存信息
        }
    }
}
