using System;

namespace StackAndQueuesProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------WELCOME TO THE STACK AND QUEQUES-----------------------\n\n");
            StackUsingLinkedlist obj = new StackUsingLinkedlist();

            obj.Push(56);
            obj.Push(30);
            obj.Push(70);

            obj.Display();

            Console.WriteLine("\nPerforming Pop operation");
            Console.WriteLine("Top peek item in stack is: {0}", obj.peek());
            obj.pop();
            Console.WriteLine("Top peek item in stack is: {0}", obj.peek());
            obj.pop();
            Console.WriteLine("Top peek item in stack is: {0}", obj.peek());
            obj.pop();
            obj.peek();




            Console.WriteLine("Adding elements to Queue");
            Queue q = new Queue();
            q.enqueue(56);
            q.enqueue(30);
            q.enqueue(70);
            Console.WriteLine("statrting element is: " + q.front.key);
        }
    }
}
