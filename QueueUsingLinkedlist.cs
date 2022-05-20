using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueuesProblem
{
    public class QNode
    {

        public int key;
        public QNode next;

        public QNode(int key)
        {
            this.key = key;
            this.next = null;
        }
    }
    class Queue
    {
        QNode front, rear;

        public Queue()
        {
            this.front = this.rear = null;
        }

        public void enqueue(int key)
        {
            QNode temp = new QNode(key);

            if (this.rear == null)
            {
                this.front = this.rear = temp;
                return;
            }
            this.rear.next = temp;
            this.rear = temp;
        }
    }
}