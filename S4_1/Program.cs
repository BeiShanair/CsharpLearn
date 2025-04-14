using System.Collections;

namespace S4_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 数据集合类
            // ArrayList是C#封装好的集合类

            // 声明，需要using System.Collections;
            ArrayList list = new ArrayList();

            // 增
            list.Add("张三");
            list.Add("李四");
            list.Add("王五");

            ArrayList list2 = new ArrayList();
            list2.Add("赵六");
            list.AddRange(list2);

            list.Insert(1, "钱七");

            // 删
            list.Remove("张三");
            list.RemoveAt(1);
            // 清空
            //list.Clear();

            // 查
            string name = (string)list[0];

            // 查看元素是否存在
            if (list.Contains("李四"))
            {
                Console.WriteLine("李四在list中");
            }

            // 正向查找元素位置
            int index = list.IndexOf("王五");

            // 反向查找元素位置
            index = list.LastIndexOf("王五");

            // 改
            list[0] = "赵六"; 

            // 遍历
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            // 长度
            Console.WriteLine(list.Count);
            // 容量
            Console.WriteLine(list.Capacity);

            // 迭代器遍历
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            // 装箱
            int i = 1;
            list[0] = i;

            // 拆箱
            i = (int)list[0];
        }
    }
}
