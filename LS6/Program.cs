namespace LS6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 类型转换-隐式转换
            #region R1
            // 大范围装小范围
            int a = 10;
            long b = a; // 隐式转换
            // short c = a; // 不能隐式转换，因为short范围 < int范围

            // decimal不能隐式转换double和float，但整型可以被转换
            double d = 10.0;
            // decimal e = d; // 不能隐式转换

            // 有符号数不能隐式转换为无符号数
            // uint f = a; // uint是无符号整数，int是有符号整数，不能隐式转换

            // 无符号数隐式转换为有符号数，要求无符号数的范围必须小于有符号数的范围
            uint g = 10;
            long h = g; // 可以隐式转换，因为uint范围 < long范围

            // 所有整型都可隐式转换为float、double
            float i = a;
            double j = b;

            // string类型和bool型不能和其他类型隐式转换
            // bool k = a; // 不能隐式转换
            // 其他类型不能隐式转换为char，但char可以隐式转换为其他类型（string，小于int范围的也不能转换）
            // char l = a; // 不能隐式转换
            char m = 'a';
            int n = m; // 其实是转换为ASCII码值
            #endregion

            // 类型转换-显式转换
            #region R2
            // 变量类型 变量名 = (目标类型)变量名
            // 注意范围，超出范围会出现数值异常
            // 精度可能丢失
            int o = 10;
            short p = (short)o; // 显式转换

            // 变量类型.Parse()方法可以将字符串转换为其他类型
            int q = int.Parse("123");
            // int r = int.Parse("123.45"); // 会报错，因为字符串中包含小数点

            short s = short.Parse("123");
            double t = double.Parse("123.45");

            // Convert.ToXXX()方法可以更准确地转换变量类型
            int u = Convert.ToInt32("123");
            int v = Convert.ToInt32(123.45);

            // 每一种类型都有对应的Convert.ToXXX()方法
            sbyte w = Convert.ToSByte("123");
            short x = Convert.ToInt16("123");
            int y = Convert.ToInt32("123");
            long z = Convert.ToInt64("123");

            byte aa = Convert.ToByte("123");
            ushort bb = Convert.ToUInt16("123");
            uint cc = Convert.ToUInt32("123");
            ulong dd = Convert.ToUInt64("123");

            float ee = Convert.ToSingle("123.45");
            double ff = Convert.ToDouble("123.45");
            decimal gg = Convert.ToDecimal("123.45");

            bool hh = Convert.ToBoolean("true"); 
            char ii = Convert.ToChar("a");

            string jj = Convert.ToString(123);

            // 所有类型都可以通过ToString()方法转换为字符串
            int a1 = 123;
            Console.WriteLine(a1.ToString());

            // Console.ReadLine()方法会读取用户输入的字符串，并返回一个string类型
            #endregion


        }
    }
}
