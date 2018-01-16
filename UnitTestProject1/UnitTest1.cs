using InterviewCore.StackAndQueue;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(0);
            stack.Push(5);
            stack.Push(2);
            stack.Push(1);
            stack.Push(9);
            var value1 = stack.Peek();
            ReverseStack.Reverse(stack);
            var value2 = stack.Peek();
            Assert.IsTrue(value1 == value2);
        }
    }
}
