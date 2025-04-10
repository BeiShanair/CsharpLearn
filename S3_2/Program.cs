namespace S3_2
{
    // 继承
    // 语法：[访问修饰符] class 子类名 : 父类名
    // 特点：子类可以继承父类的字段、方法、属性、索引器等；子类只能继承一个父类
    class A
    {
        public string name;
        public int age;

        public void Speak(string str)
        {
            Console.WriteLine(str);
        }
    }
    class B : A // B继承A
    {
        public int score;

    }

    // 里氏替换原则
    // 子类对象可以替换父类对象，且不会影响程序运行
    // 父类容器装子类对象，子类包含了父类的内容
    class GameObject
    {

    }
    class Monster : GameObject
    {
        public void Attack()
        {
            Console.WriteLine("攻击");
        }
    }
    class Player : GameObject
    {
        public void Attack()
        {
            Console.WriteLine("攻击");
        }
    }
    class Boss : GameObject
    {
        public void Attack()
        {
            Console.WriteLine("攻击");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // 使用子类
            B b = new B();
            b.name = "张三";
            b.age = 18;
            b.Speak("Hello World!");

            // 里氏替换原则
            GameObject player = new Player();
            GameObject monster = new Monster();
            GameObject boss = new Boss();

            // is 和 as
            // is：判断对象是否为某个类的实例
            // as：将对象转换为某个类的实例
            if (player is Player)
            {
                Console.WriteLine("是Player");
                Player p = player as Player;
                p.Attack();
            }
        }
    }
}
