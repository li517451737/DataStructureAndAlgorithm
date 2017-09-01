using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple.Generic
{
    /**
     在.NET 框架下通过使用 Process 类可以做到这一点。Process 类拥有的方法允许选取当前的进程、选取程序运行
    其内的线程，以及选取存储线程开始执行时间的计时器。这些方法中的每一个都可以合并成一个调用。此调用会把
    它的返回值赋值给一个变量用来存储开始时间（TimeSpan 对象）
         */
    public class Timing
    {
        private TimeSpan startTime;

        private TimeSpan duration;

        public Timing()
        {
            startTime = new TimeSpan(0);
            duration = new TimeSpan(0);
        }
        /// <summary>
        /// 停止
        /// </summary>
        public void StopTime()
        {
            duration = Process.GetCurrentProcess().Threads[0].UserProcessorTime.Subtract(startTime);
        }
        /// <summary>
        /// 开始
        /// </summary>
        public void StartTime()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            startTime = Process.GetCurrentProcess().Threads[0].UserProcessorTime;
        }
        /// <summary>
        /// 返回所用时间
        /// </summary>
        /// <returns></returns>
        public TimeSpan Result()
        {
            return duration;
        }
    }
}
