namespace S2_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 交错数组
            // 概念：交错数组是数组的数组，即“数组的数组”。
            // 特别的，交错数组可以具有不同的维度和大小。
            int[][] jaggedArray = new int[3][]; // 行数可以声明，但列数可能不同，所以不声明

            int[][] jaggedArray2 = new int[3][] {new int[] {1,2,3},
                                                 new int[] {4,5},
                                                 new int[] {6}}; // 声明并初始化

            int[][] jaggedArray3 = new int[][] { new int[] { 1, 2, 3 },
                                                 new int[] { 4, 5 },
                                                 new int[] { 6 } };

            int[][] jaggedArray4 = { new int[] { 1, 2, 3 },
                                     new int[] { 4, 5 },
                                     new int[] { 6 } };

            // 数组的长度
            Console.WriteLine(jaggedArray4.GetLength(0)); // 行数
            Console.WriteLine(jaggedArray4[0].Length); // 第一行的列数

            // 获取元素
            Console.WriteLine(jaggedArray4[1][1]); // 5

            // 修改
            jaggedArray4[1][1] = 100;

            // 遍历
            for (int i = 0; i < jaggedArray4.GetLength(0); i++)
            {
                for (int j = 0; j < jaggedArray4[i].Length; j++)
                {
                    Console.Write(jaggedArray4[i][j] + " ");
                }
            }

            // 增删查和前面的一维数组及二维数组差不多

        }
    }
}
