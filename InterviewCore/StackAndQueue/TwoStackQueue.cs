/**
 * 题目：编写一个类，用两个栈实现队列，支持队列的基本操作（add,poll,peek）
 * 
 * 思路：
 *  栈的特点是先进后出，队列的特点是先进先出。我们用两个栈正好能将顺序反过来实现队列的操作
 * 
 */


using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewCore.StackAndQueue
{
    /// <summary>
    /// 有两个栈组成的队列
    /// </summary>
    public class TwoStackQueue
    {
        private Stack<int> stackPush;//栈1，保存压入的元素
        private Stack<int> stackPop;//栈2，保存弹出的元素

        public TwoStackQueue()
        {
            stackPush = new Stack<int>();
            stackPop = new Stack<int>();
        }
        /// <summary>
        /// 添加元素
        /// </summary>
        /// <param name="newNum"></param>
        public void Add(int newNum)
        {
            stackPush.Push(newNum);
        }

        /// <summary>
        /// 移除元素并返回
        /// </summary>
        /// <returns></returns>
        public int Poll()
        {
            if (stackPush.Count == 0 && stackPop.Count == 0)
                throw new Exception("队列为空");
            else if (stackPop.Count == 0)
            {
                while (stackPush.Count != 0)//当弹出栈不为空时，不能压入
                {
                    stackPop.Push(stackPush.Pop());
                }
            }
            return stackPop.Pop();
        }
        /// <summary>
        /// 返回队列首个元素
        /// </summary>
        /// <returns></returns>
        public int Peek()
        {
            if (stackPush.Count == 0 && stackPop.Count == 0)
                throw new Exception("队列为空");
            else if (stackPop.Count == 0)
            {
                while (stackPush.Count != 0)
                {
                    stackPop.Push(stackPush.Pop());
                }
            }
            return stackPop.Peek();
        }
    }
}
