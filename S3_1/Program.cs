namespace S3_1
{
    // 类
    // 语法[访问修饰符] class 类名
    // {
    //     字段（成员变量）
    //     方法（成员方法）
    //     属性
    //     构造函数和析构函数
    //     事件
    //     索引器
    //     运算符重载
    //     ...
    // }

    // 类名在同一个命名空间中不能重复
    // 遵循帕斯卡命名法
    // 类声明实例
    enum ESex
    {
        Male,
        Female
    }
    struct Position
    {

    }
    class Person
    {
        // 字段（成员变量）
        // 语法：[访问修饰符] 数据类型 字段名;
        // 访问修饰符：public、private、protected等
        public string name = "张三"; // 在类中是可以进行初始化的
        public int age;
        public ESex sex;
        public Person[] friend; // 可以定义同名字段，但不能初始化（除了初始化为null）
        public Position position;

        // 方法（成员方法）
        // 语法：[访问修饰符] 返回值类型 方法名([参数列表])
        public void Speak(string str)
        {
            Console.WriteLine("{0}说{1}", this.name, str);
        }

        bool isAdult()
        {
            return this.age >= 18;
        }
        public void AddFriend(Person p)
        {
            if (this.friend == null)
            {
                this.friend = new Person[] { p };
            }
            else
            {
                Person[] temp = new Person[this.friend.Length + 1];
                for (int i = 0; i < this.friend.Length; i++)
                {
                    temp[i] = this.friend[i];
                }
                temp[temp.Length - 1] = p;
                this.friend = temp;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // 实例化对象
            // 语法：
            // 类名 对象名 = new 类名();
            // 类名 对象名；（不初始化）
            // 类名 对象名 = null;（空）
            // 类是引用类型的
            Person person = new Person();

            // 使用字段
            // 语法：对象名.字段名
            person.name = "李四";
            Console.WriteLine(person.name);

            // 必须实例化出对象 再通过对象来使用
            person.Speak("你好");
        }
    }
}
