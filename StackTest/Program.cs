using System;
using System.Collections.Generic;
namespace StackTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            Stack<int> originalStack = new Stack<int>(3);
            Stack<int> StackCopy = new Stack<int>(3);
            //load for test:
            for(int i = 1; i<4; i++ ) { originalStack.Push(i);}
        
            //show pop order then reload
            Console.WriteLine("Original:");
              while (originalStack.Count>0) {
                Console.WriteLine(originalStack.Pop());
                }
            //repush 
            for(int i = 1; i<4; i++ ) {
                originalStack.Push(i);
                }

            CopyStack(ref originalStack, ref StackCopy);

            Console.WriteLine("Copy: ");

            int val;
            while (StackCopy.Count>0)
            {
                val=StackCopy.Pop();
                Console.WriteLine(val);
            }

        }
        public static void CopyStack(ref Stack<int> orig, ref Stack<int> SC) {

            Queue<int> QueueTemp = new Queue<int>(3);
            
            while (orig.Count >0)  // there is no IsEmpty()
            {
                SC.Push(orig.Pop());
            }
            while (SC.Count >0)  // there is no IsEmpty()
            {
                QueueTemp.Enqueue(SC.Pop());
            }
            while (QueueTemp.Count>0) 
            {
                orig.Push(QueueTemp.Peek());
                SC.Push(QueueTemp.Dequeue());
            }
        }
    }
}
