namespace S2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 二维数组
            int[,] arr;
            int[,] arr2 = new int[3, 4];
            int[,] arr3 = new int[,] { { 1, 2, 3 }, { 4, 5, 6 } };
            int[,] arr4 = { { 1, 2, 3 }, { 4, 5, 6 } };

            // 数组的长度
            // 对于二维数组来说GetLength(0)表示获取行数
            // GetLength(1)表示获取列数
            Console.WriteLine(arr4.GetLength(0));
            Console.WriteLine(arr4.GetLength(1));

            // 获取二维数组的元素
            Console.WriteLine(arr4[0, 0]);

            // 修改二维数组的元素
            arr4[0, 0] = 100;
            Console.WriteLine(arr4[0, 0]);
            
            // 遍历
            for (int i = 0; i < arr4.GetLength(0); i++)
            {
                for (int j = 0; j < arr4.GetLength(1); j++)
                {
                    Console.WriteLine(arr4[i, j]);
                }
            }

            // 增加元素
            int[,] arr5 = new int[3, 3];
            for (int i = 0; i < arr4.GetLength(0); i++)
            {
                for (int j = 0; j < arr4.GetLength(1); j++)
                {
                    arr5[i, j] = arr4[i, j];
                }
            }
            arr4 = arr5;

            // 删除元素
            int [,] arr6 = new int[2, 2];
            for (int i = 0; i < arr6.GetLength(0); i++)
            {
                for (int j = 0; j < arr6.GetLength(1); j++)
                {
                    arr6[i, j] = arr4[i, j];
                }
            }
            arr4 = arr6;

            // 查找数组元素
            for (int i = 0; i < arr4.GetLength(0); i++)
            {
                for (int j = 0; j < arr4.GetLength(1); j++)
                {
                    if (arr4[i, j] == 100)
                    {
                        Console.WriteLine("找到了");
                    }
                }
            }
        }
    }
}
