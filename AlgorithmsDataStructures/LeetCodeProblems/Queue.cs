using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms
{
    public class Queue
    {
        public int MaxSize { get; set; }
        public int[] QueueArray { get; set; }
        public  int Front { get; set; }
        public  int Rear  { get; set; }
        public int IndexPointer { get; set; } //Pointer to keep track of Length

        public Queue(int size)
        {

            this.MaxSize = size;
            this.QueueArray = new int[size];
            Front = 0;
            Rear = -1;
        }

        public void Enqueue(int item)
        {
            Rear++;
            QueueArray[Rear] = item;
            //IndexPointer++;

        }

        public int Dequeue()
        {
            int temp = QueueArray[Front];
            Front++;
            if(Front  == MaxSize)
            {
                Front = 0;
            }
            //IndexPointer--;
            return temp;
        }

        public int Peak()
        { 
            return QueueArray[Front]; 
        }
    }
}
