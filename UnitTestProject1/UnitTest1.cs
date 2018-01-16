using InterviewCore.StackAndQueue;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            MyStack1 stack = new MyStack1();
            stack.Push(0);
            stack.Push(5);
            stack.Push(2);
            stack.Push(1);
            stack.Push(9);
            var min = stack.GetMin();
            var arr1 = stack.ConvertToArray();
            stack.Pop();
            var arr2 = stack.ConvertToArray();
            Assert.Fail();
        }
    }
}
