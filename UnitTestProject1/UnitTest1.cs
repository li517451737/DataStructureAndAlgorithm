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
            TwoStackQueue stack = new TwoStackQueue();
            stack.Add(0);
            stack.Add(5);
            stack.Add(2);
            stack.Add(1);
            stack.Add(9);
            var value = stack.Peek();
            Assert.IsTrue(value==0);
        }
    }
}
