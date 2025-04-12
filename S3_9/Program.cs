namespace S3_9
{
    // 密封方法
    // 让虚方法或者抽象方法不能被重写
    abstract class GameObject
    {
        public string name;
        public abstract void Atk();
        public virtual void Move()
        {
            Console.WriteLine("移动");
        }
    }
    class Player : GameObject
    {
        public override void Atk()
        {
            throw new NotImplementedException();
        }
        public sealed override void Move()
        {
            Console.WriteLine("玩家移动");
        }
    }
    class Player2 : Player
    {
        // 不能被重写
        //public override void Move()
        //{

        //}
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
