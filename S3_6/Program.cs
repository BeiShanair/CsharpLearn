namespace S3_6
{
    // 多态
    // 概念：同一个方法，不同的对象调用，表现出不同的行为
    // 虚函数、重写、父类
    // virtual、override、base
    class GameObject
    {
        public string name;
        public GameObject(string name)
        {
            this.name = name;
        }
        // 虚函数用于提供子类重写
        public virtual void Atk()
        {
            Console.WriteLine("普通攻击");
        }
    }
    class Player : GameObject
    {
        public Player(string name) : base(name)
        {

        }

        public override void Atk()
        {
            // 可以通过base保留父类的逻辑（类似super）
            base.Atk();
            Console.WriteLine("玩家攻击");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            GameObject obj = new Player("玩家");
            obj.Atk();
        }
    }
}
