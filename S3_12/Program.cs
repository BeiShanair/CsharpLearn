namespace S3_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // string
            // 字符串指定位置的获取
            string str = "Hello World";
            Console.WriteLine(str[0]);

            // string转char[]
            char[] chars = str.ToCharArray();
            Console.WriteLine(chars[0]);

            // 遍历字符串
            for (int i = 0; i < str.Length; i++)
            {
                Console.WriteLine(str[i]);
            }

            // 字符串拼接
            string str2 = string.Format("{0} {1}", "Hello", "World");
            Console.WriteLine(str2);

            // 正向查找
            int index = str.IndexOf("W");
            Console.WriteLine(index);
            int index2 = str.IndexOf("1"); // 找不到返回-1
            Console.WriteLine(index2);

            // 反向查找
            int index3 = str.LastIndexOf("o");
            Console.WriteLine(index3);

            // 移除指定位置字符
            string str3 = str.Remove(5, 1); // 第二个参数是字符个数，缺省则移除第一个参数索引之后的所有内容
            Console.WriteLine(str3);

            // 替换
            string str4 = str.Replace("o", "a");
            Console.WriteLine(str4);

            // 大小写转化
            string str5 = str.ToUpper();
            Console.WriteLine(str5);

            string str6 = str.ToLower();
            Console.WriteLine(str6);

            // 字符串截取
            string str7 = str.Substring(2, 5); // 第二个参数同上
            Console.WriteLine(str7);

            // 字符串切割
            // 返回string的数组
            string[] strs = str.Split(' ');
            for (int i = 0; i < strs.Length; i++)
            {
                Console.WriteLine(strs[i]);
            }
        }
    }
}
