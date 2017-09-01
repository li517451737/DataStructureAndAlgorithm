using System;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 3, 12, 52, 11, 23, 56, 75, 87 };
            var selectArr = InsertionSort(arr1);
            DisplayData(selectArr);
            Console.ReadKey();
        }
        static void DisplayData(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + ",");
            }
            Console.WriteLine();
        }

        static int[] SelectSort(int[] oldArr)
        {
            int temp, min;
            for (int i = 0; i < oldArr.Length; i++)
            {
                min = i;
                //循环选择出最小值的下标
                for (int j = i + 1; j < oldArr.Length; j++)
                {
                    if (oldArr[j] < oldArr[min]) min = j;
                }
                temp = oldArr[i];
                oldArr[i] = oldArr[min];
                oldArr[min] = temp;
            }
            return oldArr;
        }

        static int[] InsertionSort(int[] oldArr)
        {
            int temp, inner;
            for (int i = 0; i < oldArr.Length; i++)
            {
                temp = oldArr[i];
                inner = i;
                while (inner > 0 && oldArr[inner-1] >= temp)
                {
                    oldArr[inner] = oldArr[inner - 1];
                    inner -= 1;
                }
                oldArr[inner] = temp;
            }
            return oldArr;
        }
    }
}
