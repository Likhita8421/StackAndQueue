using System;

    namespace StacksAndQueues
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------Concept of stack(push and pop operation)--------------");
            LinkedListStack value = new LinkedListStack();
            value.push(70);
            value.push(30);
            value.push(56);
            value.DisPlay();
            value.Peek();
             value.Pop();
            value.IsEmpty();


            /*Console.WriteLine("-----------------Concept of Queue(enque&dequeue)---------------");
            StacksAndQueues.LinkedListQueue Queue = new StacksAndQueues.LinkedListQueue();
            Queue.Enqueue(56);
            Queue.Enqueue(30);
            Queue.Enqueue(70);
            Queue.DisPlay();
            Queue.Dequeue();*/




        }
    }
}