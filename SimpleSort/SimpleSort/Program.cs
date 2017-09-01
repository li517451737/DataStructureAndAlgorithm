using Simple.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 10000;
            Random rm = new Random(100);
            CArray arr = new CArray(size);
            for (int i = 0; i < size; i++)
            {
                arr.Insert(rm.Next(1, 10000));
            }
            Timing sortTime = new Timing();
            arr.BubbleSort();
            sortTime.StartTime();
            arr.BinSearch(6878);
            sortTime.StopTime();
            sortTime.StartTime();
            arr.RbinSearch(3462, 0, size - 1);
            sortTime.StopTime();
            Console.WriteLine("冒泡排序所用时间：" + sortTime.Result().TotalMilliseconds);

            Console.ReadKey();
        }
    }
}
