namespace S2_8
{
    internal class Program
    {
        // 可变参数
        // 相当于Java中的...
        static int Sum(params int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }
        // params只能放在参数列表的最后
        static int Sum2(int a, params int[] numbers)
        {
            int sum = a;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }
        // 默认参数
        // 支持多参数默认值，但如果要混用，则必须放在普通参数后面
        static int Sum3(int a, int b = 0, int c = 0)
        {
            return a + b + c;
        }
        static void Main(string[] args)
        {
            int sum1 = Sum(1, 2, 3, 4, 5);
            Console.WriteLine(sum1);

            int sum2 = Sum(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
            Console.WriteLine(sum2);

            int sum3 = Sum2(1, 2, 3, 4, 5, 6, 7, 8);
            Console.WriteLine(sum3);

            int sum4 = Sum3(1);
            Console.WriteLine(sum4);
        }
    }
}
