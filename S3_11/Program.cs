namespace S3_11
{
    class Test
    {
        public int i = 1;
        public Test2 t2 = new Test2();
        public Test Clone()
        {
            return MemberwiseClone() as Test;
        }
    }

    class Test2
    {
        public int i = 2;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Object类中的静态方法
            // Equals 判断两个对象是否相等
            Console.WriteLine(Object.Equals(1, 1));

            Test test1 = new Test();
            Test test2 = new Test();
            Console.WriteLine(Object.Equals(test1, test2));

            // ReferenceEquals 判断两个对象是否是同一个对象（引用）
            Console.WriteLine(Object.ReferenceEquals(test1, test2));

            // 成员方法
            // GetType 获取当前对象的类型
            Console.WriteLine(test1.GetType());

            // MemberwiseClone 创建当前对象的浅拷贝
            // 浅拷贝：只拷贝对象本身，不拷贝对象中的引用类型
            Test test3 = test1.Clone();
            Console.WriteLine("克隆对象后：");
            Console.WriteLine(test1.i);
            Console.WriteLine(test1.t2.i);
            Console.WriteLine(test3.i);
            Console.WriteLine(test3.t2.i);

            test3.i = 3;
            test3.t2.i = 4;
            Console.WriteLine("改变值后的：");
            Console.WriteLine(test1.i);
            Console.WriteLine(test1.t2.i);
            Console.WriteLine(test3.i);
            Console.WriteLine(test3.t2.i);

            // 虚方法
            // Equals 默认还是比较两者是否为同一个引用，即相当于ReferenceEquals
            // 微软重写该方法，用于比较值相等
            // 我们也可以自己重写方法，定义自己的比较规则

            // GetHashCode 获取当前对象的哈希值

            // ToString 获取当前对象的字符串表示
        }
    }
}
