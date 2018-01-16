/**
 * 实现一个特殊的栈，在实现栈的基础功能的基础上，在实现返回栈中最小元素的操作
 * 
 * 要求：
 * 1. pop、push、getMin操作的时间复杂度都是O(1);
 * 2. 设计的栈类型可以使用现成的栈结构。
 * 
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewCore.StackAndQueue
{
    /**
     * 思路1：使用两个栈，一个用来保存栈中元素，其功能和正常栈一样，另一个用于保存每次操作的最小值。
     * 
     */
    
    public class MyStack1
    {
        private Stack<int> _mainStack;//保存栈中的数据
        private Stack<int> _minStack;//保存每次操作的最小元素

        public MyStack1()
        {
            _mainStack = new Stack<int>();
            _minStack = new Stack<int>();
        }

        public void Push(int newNum)
        {
            if (this._minStack.Count == 0)
                this._minStack.Push(newNum);
            else if (newNum <= this.GetMin())
                this._minStack.Push(newNum);
            this._mainStack.Push(newNum);
        }
        /// <summary>
        /// 由于_minStack的栈顶元素是_mainStack中的最小值，所以当_mainStack弹出数据时，判断是否等于_minStack的栈顶元素，等于的话_minStack也弹出。
        /// </summary>
        /// <returns></returns>
        public int Pop()
        {
            if (this._mainStack.Count == 0)
                throw new Exception("Stack is Emputy!");
            int value = this._mainStack.Pop();
            if (value == this.GetMin())
                this._minStack.Pop();
            return value;
        }
        /// <summary>
        /// 获取栈中最小元素
        /// </summary>
        /// <returns></returns>
        public int GetMin()
        {
            if (this._minStack.Count == 0)
                throw new Exception("Stack is Emputy!");
            return this._minStack.Peek();
        }
        /// <summary>
        /// 转换为数组
        /// </summary>
        /// <returns></returns>
        public int[] ConvertToArray()
        {
            return _mainStack.ToArray();
        }
    }
}
