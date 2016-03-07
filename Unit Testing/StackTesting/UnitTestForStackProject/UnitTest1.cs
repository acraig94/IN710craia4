using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StackTesting;

namespace UnitTestForStackProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IsEmpty_NewStack_ReturnsTrue()
        {
            Stack testStack = new Stack();

            bool expected = true;

            bool actual = testStack.IsEmpty();

            Assert.AreEqual(expected, actual);            
        }

        [TestMethod]
        public void IsEmpty_FullStack_ReturnsFalse()
        {
            Stack testStack = new Stack();

            testStack.Push("Bob");
            testStack.Push("Fred");

            bool expected = false;

            bool actual = testStack.IsEmpty();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Count_PushnItems_Returnsn()
        {
            Stack testStack = new Stack();

            testStack.Push("Bob");
            testStack.Push("Fred");

            int expected = 2;

            int actual = testStack.Count();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Peek_PushItemx_Returnsx()
        {
            Stack testStack = new Stack();

            testStack.Push("Bob");
            testStack.Push("Fred");

            string expected = "Fred";

            string actual = testStack.Peek();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Pop_Itemx_Returnsx()
        {
            Stack testStack = new Stack();

            testStack.Push("Bob");
            testStack.Push("Fred");

            string expected = "Fred";

            string actual = testStack.Pop();

            Assert.AreEqual(expected, actual);
        }

        // Fails
        [TestMethod]
        public void Pop_DeleteTest_ReturnCountAfterPop()
        {
            Stack testStack = new Stack();
            testStack.Push("Fred");
            testStack.Pop();

            int expected = 0;

            int actual = testStack.Count();

            Assert.AreEqual(expected, actual);

        }

        // Fails
        [TestMethod]
        public void IsEmpty_DeleteTest_ReturnTrue()
        {
            Stack testStack = new Stack();
            testStack.Push("Fred");
            testStack.Push("Max");
            testStack.Push("Jim");
            testStack.Push("Tom");
            testStack.Pop();
            testStack.Pop();
            testStack.Pop();
            testStack.Pop();

            bool expected = true;

            bool actual = testStack.IsEmpty();

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Count_OnNewStack_Return0()
        {
            Stack testStack = new Stack();
            
            int expected = 0;

            int actual = testStack.Count();

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException),"Can't call Pop on an empty Stack")]
        public void Pop_OnEmptyStack_ReturnException()
        {
            Stack testStack = new Stack();

            testStack.Pop();

        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException), "Can't call Peek on an empty Stack")]
        public void Peek_nonString_ReturnException()
        {
            Stack testStack = new Stack();

            testStack.Peek();

        }

        [TestMethod]
        public void Peek_PushManyItems_ReturnLastItemPushed()
        {
            Stack testStack = new Stack();
            testStack.Push("Fred");
            testStack.Push("Max");
            testStack.Push("Jim");
            testStack.Push("Tom");
            
            string expected = "Tom";

            string actual = testStack.Peek();

            Assert.AreEqual(expected, actual);

        }

    }
}
