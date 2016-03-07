using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackTesting
{
    public class Stack
    {

        public class StringNode
        {
            public StringNode Next;
            public string Str;

            public StringNode(string str)
            {
                Str = str;
                //Next = null;
                
            }
        }

        StringNode headPointer; // = null;
        StringNode tailPointer; // = null;

        public Stack()
        {
            headPointer = null;
            tailPointer = null;
        }

        public void Push(string newString)
        {
            StringNode newNode = new StringNode(newString);
            /*if (!(newString is string))
            {
                throw new ArgumentException("Argument passed in is invalid");
            }*/
            if (headPointer == null)
            {
                headPointer = newNode;
                tailPointer = newNode;
            }            
            else
            {
                tailPointer.Next = newNode;
                tailPointer = newNode;
            }            
        }

        public string Pop()
        {            
            string lastItem = tailPointer.Str.ToString();
            StringNode nodeWalker = headPointer;
            //StringNode nodeToDelete = tailPointer;
            
            if (headPointer == null)
            {
                // if pop is called on empty stack
                throw new NullReferenceException("Can't call Pop on an empty Stack");
            }

            if (nodeWalker != tailPointer)
            {
                while (nodeWalker.Next != tailPointer)
                {
                    nodeWalker = nodeWalker.Next;
                }
                tailPointer = nodeWalker;
            }
            else
            {
                headPointer = null;
                tailPointer = null;
            }

            return lastItem;
            
        }

        public string Peek()
        {
            if (headPointer == null)
            {
                throw new NullReferenceException("Can't call Peek on an empty Stack");
            }
 
            return tailPointer.Str.ToString();
        }

        public int Count()
        {
            int count = 0;
            StringNode nodeWalker = headPointer;

            while (nodeWalker != null)
            {
                count++;
                nodeWalker = nodeWalker.Next;
            }

            return count;
        }

        public bool IsEmpty()
        {
            bool empty = false;

            if (headPointer == null)
            {
                empty = true;
            }

            return empty;
        }

    }
}
