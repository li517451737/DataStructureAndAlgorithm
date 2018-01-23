using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewCore.Sorts
{
    public class NumberSort
    {
        /// <summary>
        /// 随机排序算法
        /// </summary>
        /// <param name="arrs"></param>
        /// <returns></returns>
        public static void RandomSort(ref int[] arrs)
        {
            Random randomBuilder = new Random();
            int swapTarget, swapTemp;
            for (int i = 0; i < arrs.Length; i++)
            {
                swapTarget = randomBuilder.Next(0, arrs.Length);
                swapTemp = arrs[i];
                arrs[i] = arrs[swapTarget];
                arrs[swapTarget] = swapTemp;
            }
        }
    }
}
