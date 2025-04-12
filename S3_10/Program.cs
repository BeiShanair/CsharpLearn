// 引用命名空间
// using 命名空间名称;
using MyGame;
// 命名空间
// 命名空间是用来组织和重用代码

// 命名空间的使用
// 基本语法
// namespace 命名空间名称
// {
//     // 命名空间中的代码
// }
namespace MyGame
{
    class GameObject
    {
        public string name;
    }
}

// 不同命名空间中的类名可以相同
namespace MyGame2
{
    class GameObject
    {
        public string name;
    }
}

// 命名空间可以嵌套
namespace MyGame3
{
    namespace Game
    {
        class GameObject
        {
            public string name;
        }
    }
}

namespace S3_10
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            // 使用不同命名空间中的类
            GameObject obj = new GameObject();
            MyGame.GameObject obj2 = new MyGame.GameObject();
        }
    }
}
