namespace S3_7
{
    // 抽象类
    // 概念：不能被实例化的类，只能被继承
    // 语法： abstract class 类名 { }
    abstract class GameObject
    {
        public string name;

        // 抽象函数
        // 概念：没有函数体的函数
        // 语法： abstract 返回值类型 函数名(参数列表);
        // 不能是私有的
        // 继承后必须重写
        public abstract void Atk();
    }

    class Player : GameObject
    {
        public override void Atk()
        {
            throw new NotImplementedException();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
