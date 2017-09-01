using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple.Generic
{
    public class CArray
    {
        private int[] arr;
        private int upper;
        private int numElements;

        public CArray(int size)
        {
            arr = new int[size];
            upper = size - 1;
            numElements = 0;
        }
        /// <summary>
        /// 添加元素
        /// </summary>
        /// <param name="item"></param>
        public void Insert(int item)
        {
            arr[numElements] = item;
            numElements++;
        }

        public void DisplayElement()
        {
            for (int i = 0; i <= upper; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
        /// <summary>
        /// 清空元素
        /// </summary>
        public void Clear()
        {
            for (int i = 0; i <= upper; i++)
            {
                arr[i] = 0;
                numElements = 0;
            }
        }
        /// <summary>
        /// 冒泡排序
        /// </summary>
        public void BubbleSort()
        {
            int temp;
            for (int i = 0; i <= upper; i++)
            {
                for (int j = i + 1; j <= upper; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }
        /// <summary>
        /// 选择排序
        /// </summary>
        public void SelectSort()
        {
            int min, temp;
            for (int outer = 0; outer <= upper; outer++)
            {
                min = outer;
                for (int inner = outer + 1; inner <= upper; inner++)
                {
                    if (arr[inner] < arr[min]) min = inner;
                }
                temp = arr[outer];
                arr[outer] = arr[min];
                arr[min] = temp;
            }
        }
        /// <summary>
        /// 插入排序
        /// 插入排序算法有两层循环。外层循环会逐个遍历数组元素，而内层循环则会把外层循环所选择的元素与该元素
        ///  在数组内的下一个元素进行比较。如果外层循环选择的元素小于内层循环选择的元素，那么数组元素都向右移以便
        ///  为内层循环元素留出位置
        /// </summary>
        public void InsertionSort()
        {
            int inner, temp;
            for (int outer = 0; outer <= upper; outer++)
            {
                temp = arr[outer];
                inner = outer;
                while (inner > 0 && arr[inner - 1] >= temp)
                {
                    arr[inner] = arr[inner - 1];
                    inner -= 1;
                }
                arr[inner] = temp;
            }
        }


        /// <summary>
        /// 二叉查找法
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public int BinSearch(int value)
        {
            int upperBound, lowerBound, mid;
            upperBound = arr.Length - 1;
            lowerBound = 0;
            while (lowerBound <= upperBound)
            {
                mid = (upperBound + lowerBound) / 2;
                if (arr[mid] == value)
                {
                    return mid;
                }
                else
                {
                    if (value < arr[mid])
                    {
                        upperBound = mid - 1;
                    }
                    else
                    {
                        lowerBound = mid + 1;
                    }
                }
            }
            return -1;
        }
        /// <summary>
        /// 递归二叉查找法，同迭代算法相比，递归效率较低
        /// </summary>
        /// <param name="value">查找的数值</param>
        /// <param name="lower">开始查找的坐标</param>
        /// <param name="upper">结束的坐标</param>
        /// <returns></returns>
        public int RbinSearch(int value, int lower, int upper)
        {
            if (lower > upper)
            {
                return -1;
            }
            else
            {
                int mid = (upper + lower) / 2;
                if (value < arr[mid])
                {
                    return RbinSearch(value, lower, mid - 1);
                }
                else if (value == arr[mid])
                {
                    return mid;
                }
                else
                {
                    return RbinSearch(value, mid + 1, upper);
                }
            }
        }
    }
}
