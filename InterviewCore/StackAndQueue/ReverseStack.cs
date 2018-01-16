/**
 * 题目：仅用递归函数和栈逆序一个栈
 * 
 * 思路：本地需要设计两个递归函数，一个递归获取栈底的元素并移除， 二 逆序一个栈
 */ 

using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewCore.StackAndQueue
{
    public class ReverseStack
    {
        /// <summary>
        /// 使用递归的方式返回并移除栈底的元素
        /// </summary>
        /// <param name="stack"></param>
        /// <returns></returns>
        public static int GetAndRemoveLastElement(Stack<int> stack)
        {
            int result = stack.Pop();
            if (stack.Count == 0)
                return result;
            else
            {
                int last = GetAndRemoveLastElement(stack);
                stack.Push(result);
                return last;
            }
        }
        /// <summary>
        /// 逆序栈中的元素
        /// </summary>
        /// <param name="stack"></param>
        public static void Reverse(Stack<int> stack)
        {
            if (stack.Count == 0)
                return;
            int i = GetAndRemoveLastElement(stack);
            Reverse(stack);
            stack.Push(i);
        }
    }
}
