using System;

namespace LS2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("变量");

            #region Region
            // 实际编译时，Region会被忽略
            // 有符号的整型sbyte short int long
            sbyte a = 100; // -128~127
            short b = 100; // -32768~32767
            int c = 100; // -2147483648~2147483647
            long d = 100; // -9223372036854775808~9223372036854775807
            
            // 无符号的整型byte ushort uint ulong
            byte e = 100; // 0~255
            ushort f = 100; // 0~65535
            uint g = 100; // 0~4294967295
            ulong h = 100; // 0~18446744073709551615

            // 浮点型 float double decimal
            float i = 100.0f; // 7~8位有效数字
            double j = 100.0; // 15~17位有效数字
            decimal k = 100.0m; // 28~29位有效数字

            // 布尔
            bool l = true; // true false
            bool m = false; // true false

            // 字符
            char n = 'a'; // 只能存储一个字符

            // 字符串
            string o = "hello world"; // 可以存储多个字符

            // 同时申明多个相同类型的变量
            int a1 = 1, a2 = 2, a3 = 3;

            // 变量初始化
            int b1;
            b1 = 1;
            Console.WriteLine(b1);

            #endregion

            // 变量命名规范
            // 1. 变量名必须以字母、下划线开头
            // 2. 变量名只能包含字母、数字、下划线，并区分大小写，不能重复
            // 3. 变量名不能使用关键字
            // 4. 变量名应当顾名思义
            // 5. 一般遵循驼峰命名法，即首字母小写，后续每个单词首字母大写（函数、类可采用大驼峰命名法）
        }
    }
}
