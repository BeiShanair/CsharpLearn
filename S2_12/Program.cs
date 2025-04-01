namespace S2_12
{
    internal class Program
    {
        // 冒泡排序
        // 原理从数组的第一个元素开始，依次比较相邻的两个元素，如果前一个元素大于后一个元素，则交换它们的位置
        static int[] BubbleSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            return arr;
        }
        static void Main(string[] args)
        {
            int[] arr = { 5, 3, 8, 6, 2, 7, 1, 4 };
            int[] result = BubbleSort(arr);
            foreach (int i in result)
            {
                Console.Write(i + " ");
            }
        }
    }
}
