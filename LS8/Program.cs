namespace LS8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 运算符
            // 赋值运算符 =
            int a = 1;

            // 算术运算符 + - * / % ++ --
            int b = 2;
            int c = a + b;
            Console.WriteLine(c);
            int d = a - b;
            Console.WriteLine(d);
            int e = a * b;
            Console.WriteLine(e);
            int f = a / b; // 如果两个整型相除，结果还是整型，且不会四舍五入
            Console.WriteLine(f);
            int g = a % b;
            Console.WriteLine(g);
            // a++; // 先返回a的值，再a+1
            Console.WriteLine("a++ = " + a++);
            // ++a; // 先a+1，再返回a的值
            Console.WriteLine("++a = " + ++a);
            a--;
            Console.WriteLine(a);

            // 复合运算符 += -= *= /= %=
            a += b;
            Console.WriteLine(a);
            a -= b;
            Console.WriteLine(a);
            a *= b;
            Console.WriteLine(a);
            a /= b;
            Console.WriteLine(a);
            a %= b;
            Console.WriteLine(a);

            // 括号可以改变运算的顺序
            a = (c + d) * e;
            Console.WriteLine(a);

            // 条件运算符 == != > < >= <=
            int h = 3;
            Console.WriteLine(a == h);
            Console.WriteLine(a != h);
            Console.WriteLine(a > h);
            Console.WriteLine(a < h);
            Console.WriteLine(a >= h);
            Console.WriteLine(a <= h);
            // 任意数值可以直接进行比较
            // 特殊类型 string char bool只能同类型进行== !=比较

            // 逻辑运算符 && || !
            Console.WriteLine(a > h && b > h);
            Console.WriteLine(a > h || b > h);
            Console.WriteLine(!(a > h));
            // 逻辑运算符的短路规则
            // && 只要有一个为假，则结果为假，且后面的不执行
            // || 只要有一个为真，则结果为真，且后面的不执行
            int i = 0;
            Console.WriteLine(i > 0 && i++ > 0);
            Console.WriteLine("i = " +i);

            int j = 0;
            Console.WriteLine(++j > 0 || j++ > 0);
            Console.WriteLine("j = " + j);
            // 字符串拼接
            string str = "hello";
            Console.WriteLine(str + " world");

            string str1;
            str1 = String.Format("{0} world", str); // {}占位符
            Console.WriteLine(str1);

            // 位运算& | ^ ~ << >>
            // & 有0则0，全1则1
            // | 有1则1，全0则0
            // ^ 相同则0，不同则1
            int i1 = 2;
            int j1 = 3;
            Console.WriteLine(i1 & j1); // 2
            Console.WriteLine(i1 | j1); // 3
            Console.WriteLine(i1 ^ j1); // 1

            // ~ 取反
            Console.WriteLine(~i1); // -3
            // << 左移，相当于乘以2的n次方
            Console.WriteLine(i1 << 1); // 4
            // >> 右移，相当于除以2的n次方
            Console.WriteLine(i1 >> 1); // 1

            // 三目运算符 表达式1 ? 表达式2 : 表达式3
            // 如果表达式1为真，则返回表达式2，否则返回表达式3
            int k = 1;
            int l = 2;
            int m = k > l ? k : l;
            Console.WriteLine(m);

            // 优先级() > ++ -- > ! > 算术运算符 > 条件运算符 > 逻辑运算符 > 赋值运算符
        }
    }
}
