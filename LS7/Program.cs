namespace LS7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 异常捕获
            // 防止程序在运行时出现异常而终止

            // 基本语法
            // 必须写的部分try-catch
            try
            {
                // 放可能出现异常的代码
                string a = Console.ReadLine();
                int b = int.Parse(a);
                Console.WriteLine(b);
            }
            catch (Exception ex)
            {
                // 当捕获到异常时执行的代码
                Console.WriteLine("Failed");
            }
            // 可选写的部分finally
            finally
            {
                // 无论是否发生异常都会执行的代码
            }
        }
    }
}
