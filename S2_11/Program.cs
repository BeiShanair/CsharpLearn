namespace S2_11
{
    // 结构体
    // 它是一种自定义数据类型，用于存储一组相关的数据
    // 结构体中的数据成员可以是不同类型的数据

    // 结构体的定义
    // 使用 struct 关键字定义结构体，一般写在namespace中
    struct Student
    {
        // 变量
        public string name;
        public bool sex;
        public int num;
        public int age;
        public string major;
        // 构造函数（可省略）
        public Student(string name, bool sex, int num, int age, string major)
        {
            this.name = name;
            this.sex = sex;
            this.num = num;
            this.age = age;
            this.major = major;
        }

        // 函数
        public void Speak()
        {
            Console.WriteLine("我叫{0}，今年{1}岁，性别{2}，学号{3}，专业{4}。", name, age, sex ? "男" : "女", num, major);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1;
            s1.name = "张三";
            s1.sex = true;
            s1.num = 1001;
            s1.age = 20;
            s1.major = "计算机科学与技术";
            s1.Speak();

            Student s2 = new Student("李四", false, 1002, 21, "软件工程");
            s2.Speak();
        }
    }
}
