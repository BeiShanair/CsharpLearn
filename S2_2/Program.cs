namespace S2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 数组，存储一组相同类型数据的集合
            // 一维数组、二维数组、多维数组、交错数组

            // 数组声明
            // 数据类型[] 数组名;
            int[] arr1;
            // 数据类型[] 数组名 = new 数据类型[数组长度];
            int[] arr2 = new int[5];
            // 数据类型[] 数组名 = {元素1, 元素2, 元素3, ...};
            int[] arr3 = { 1, 2, 3, 4, 5 };
            // 数据类型[] 数组名 = new 数据类型[数组长度] {元素1, 元素2, 元素3, ...};
            int[] arr4 = new int[5] { 1, 2, 3, 4, 5 };
            // 数据类型[] 数组名 = new 数据类型[] {元素1, 元素2, 元素3, ...};
            int[] arr5 = new int[] { 1, 2, 3, 4, 5 };
            
            // 数组的长度
            Console.WriteLine(arr3.Length);

            // 获取数组元素
            // 数组名[索引] 索引不得越界
            Console.WriteLine(arr3[0]);

            // 修改数组元素
            arr3[0] = 10;
            Console.WriteLine(arr3[0]);

            // 遍历数组
            for (int i = 0; i < arr3.Length; i++)
            {
                Console.WriteLine(arr3[i]);
            }

            // 增加数组的元素
            // 数组其实在初始化之后，是不能直接添加新的元素的
            int [] arr6 = new int[6];
            // 搬家
            for (int i = 0; i < arr3.Length; i++)
            {
                arr6[i] = arr3[i];
            }
            arr3 = arr6;

            // 删除数组中的元素
            // 与增加数组一样，数组在初始化之后，是不能直接删除元素的
            int[] arr7 = new int[4];
            for (int i = 0; i < arr7.Length; i++)
            {
                arr7[i] = arr3[i];
            }
            arr3 = arr7;

            // 查找数组元素
            // 只能通过遍历去判断
            for (int i = 0; i < arr3.Length; i++)
            {
                if (arr3[i] == 10)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
