using System.Text;

namespace S3_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // StringBuilder
            // C# 提供的用于处理字符串的类
            // 修改字符串而不创建新的字符串，需要频繁修改的字符串可使用
            // 使用前需引用命名空间using System.Text;
            StringBuilder sb = new StringBuilder("123123");
            Console.WriteLine(sb);

            // 获取容量
            Console.WriteLine(sb.Capacity);
            // 可以在声明的时候指定容量
            StringBuilder sb2 = new StringBuilder("123123", 100);

            // 获取字符长度
            Console.WriteLine(sb.Length);

            // 增
            sb.Append("456");
            Console.WriteLine(sb);

            sb.AppendFormat("{0}{1}{2}", 1, 2, 3);
            Console.WriteLine(sb);

            // 插入
            sb.Insert(0, "789");
            Console.WriteLine(sb);

            // 删
            sb.Remove(0, 3);
            Console.WriteLine(sb);

            // 查
            Console.WriteLine(sb[0]);

            // 改
            sb[0] = '0';
            Console.WriteLine(sb);

            // 替换
            sb.Replace("456", "789");
            Console.WriteLine(sb);

            // 清空
            sb.Clear();
            Console.WriteLine(sb);

            // 重新赋值
            // 先清空再Append
            sb.Append("123456789");
            Console.WriteLine(sb);
        }
    }
}
