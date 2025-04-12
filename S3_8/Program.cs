namespace S3_8
{
    // 接口
    // 概念：接口是一种引用类型，它定义了一组方法，但不实现这些方法
    // 接口中的方法默认是public的，不能是私有的
    // 不包含成员变量，只包含方法、属性、索引器、事件
    // 成员不能被实现
    // 接口不能继承类，但可以可以继承接口
    // 语法： interface 接口名 { }
    
    interface IAnimal
    {
        void Eat();
        // 属性只能使用自动属性
        string name
        {
            get;
            set;
        }

        int this[int index]
        {
            get;
            set;
        }

        event Action Event;
    }

    // 一个类可以实现多个接口
    // 类实现接口必须实现接口中的所有成员
    class Animal : IAnimal
    {
        public int this[int index] 
        { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); 
        }

        public string name 
        { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); 
        }

        public event Action Event;

        public void Eat()
        {
            throw new NotImplementedException();
        }
    }

    // 接口继承接口
    interface IAnimal2 : IAnimal
    {
        void walk();
    }
    // 一个类可以实现多个接口
    class Animal2 : IAnimal, IAnimal2
    {
        public int this[int index] 
        { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); 
        }

        public string name 
        { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); 
        }

        public event Action Event;

        public void Eat()
        {
            throw new NotImplementedException();
        }
    }

    // 显式实现接口
    interface IAtk
    {
        void Atk();
    }
    interface ISuperAtk
    {
        void Atk();
    }

    class Player : IAtk, ISuperAtk
    {
        // 显式实现接口
        void IAtk.Atk()
        {
            throw new NotImplementedException();
        }

        void ISuperAtk.Atk()
        {
            throw new NotImplementedException();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            IAnimal animal = new Animal();
        }
    }
}
