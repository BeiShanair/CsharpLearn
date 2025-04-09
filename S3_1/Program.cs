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
        private int money;
        private int hegiht;
        public int[,] arr;

        // 构造函数
        // 语法：[访问修饰符] 类名([参数列表])
        public Person()
        {
            name = "张三";
            age = 18;
        }
        // 构造函数可以重载
        // 有参构造函数会顶掉无参构造函数
        public Person(string name, int age) : this() // 调用无参构造函数
        {
            this.name = name;
            this.age = age;
        }

        // 析构函数
        // 概念：当对象被销毁时，会自动调用析构函数
        // 语法：~类名()
        ~Person()
        {
            Console.WriteLine("对象被销毁了");
        }

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

        // 成员属性
        // 语法：[访问修饰符] 数据类型 属性名 { get; set; }
        // 保护成员变量，为成员属性的获取和赋值添加逻辑处理，属性让成员变量在外部，只能获取不能修改
        public int Money
        {
            // 内部的方法可以添加访问修饰符
            // 但访问修饰符的权限不能比属性本身大
            // 且get和set不能同时低于外部的访问修饰符
            get
            {
                return money;
            }
            set
            {
                // value是属性赋值时传入的值
                this.money = value;
            }
        }
        // 自动属性
        // 当一个特征希望外部能得到，但不能修改，且没有特殊处理时，可以用自动属性
        // 语法：[访问修饰符] 数据类型 属性名 { get; set; }
        public int Height
        {
            get;
            set;
        }

        // 索引器
        // 让对象可以像数组一样使用，通过索引来访问成员
        // 语法：[访问修饰符] 数据类型 this[索引类型 索引名]
        public Person this[int index]
        {
            get
            {
                if (friend == null || index >= friend.Length || index < 0)
                {
                    return null;
                }
                return this.friend[index];
            }
            set
            {
                if (friend == null)
                {
                    friend = new Person[] { value };
                }
                else if (index > friend.Length - 1 || index < 0)
                {
                    friend[friend.Length - 1] = value;
                }
                // value是索引器赋值时传入的值
                this.friend[index] = value;
            }
        }
        // 索引器重载
        // 语法：[访问修饰符] 数据类型 this[索引类型 索引名1, 索引类型 索引名2]
        // 索引器可以重载，但索引类型和索引数量必须不同
        public int this[int i, int j]
        {
            get
            {
                return arr[i, j];
            }
            set
            {
                if (arr == null)
                {
                    arr = new int[i, j];
                }
                this.arr[i, j] = value;
            }
        }
    }



    // 垃圾回收机制
    // 垃圾回收的过程是在遍历堆对象引用表，找到没有被引用的对象，然后释放内存
    // 垃圾回收机制是自动的，但是可以手动调用
    // 垃圾回收有多种算法
    // 引用计数、标记-清除、标记-整理、复制集合
    // GC只负责堆上的，栈上的对象由系统自动回收
    // 大致过程：代，当代满的时候，将会触发一次垃圾回收，随后标记对象，将对象分为可回收和不可回收，不可回收的对象将会被移动到另一代，然后释放内存
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

            // 手动触发垃圾回收
            // 一般是在Loading（过场）的时候触发
            GC.Collect();

            person.Money = 100;
            Console.WriteLine(person.Money);

            // 索引器使用
            person[0] = new Person();
            Console.WriteLine(person[0].name);
        }
    }
}
