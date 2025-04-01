namespace S2_13
{
    internal class Program
    {
        // 选择排序
        // 原理从第一个元素开始，与后面的元素依次比较，找到最小（最大）的元素，放入目标位置
        static int[] SelectionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }
                if (minIndex != i)
                {
                    int temp = arr[i];
                    arr[i] = arr[minIndex];
                    arr[minIndex] = temp;
                }
            }
            return arr;
        }
        static void Main(string[] args)
        {
            int[] arr = { 1, 3, 5, 7, 9, 2, 4, 6, 8, 0 };
            int[] sortedArr = SelectionSort(arr);
            foreach (int i in sortedArr)
            {
                Console.Write(i + " ");
            }
        }
    }
}
