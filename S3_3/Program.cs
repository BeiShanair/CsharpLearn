namespace S3_3
{
    // 继承中的构造函数
    // 当声明一个构造函数时，先执行父类的构造函数，再调用子类的构造函数
    // 父类的无参构造函数很重要
    // 子类可以通过base()来调用父类的构造函数
    class A
    {
        public string name;
        public int age;

        public A()
        {
            Console.WriteLine("A的构造函数被调用了");
        }
    }
    class B : A // B继承A
    {
        public int score;
        public B()
        {
            Console.WriteLine("B的构造函数被调用了");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            B b = new B();
        }
    }
}
