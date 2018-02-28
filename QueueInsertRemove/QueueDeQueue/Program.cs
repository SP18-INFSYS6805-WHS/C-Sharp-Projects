using System;
using static System.Console;


namespace QueueInsertRemove
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Queue Insert and Remove front and rear items app\n");

            //create an instance Queue myQueue
            Queue myQueue = new Queue(5);
            myQueue.insert(100);
            myQueue.insert(10);
            myQueue.insert(20);
            myQueue.insert(30);
            myQueue.insert(45);
            myQueue.view();

            WriteLine($"Front of queue is {myQueue.peekFront()} ");
            WriteLine($"Rear of queue is {myQueue.peekRear()} ");

            //remove an item from the front
            WriteLine($"\nAbout to remove an item from the front of the queue\n");
            myQueue.removeFront();


            WriteLine($"Front of queue is {myQueue.peekFront()} ");
            WriteLine($"Rear of queue is {myQueue.peekRear()} ");

            //remove an item from the rear
            WriteLine($"\nAbout to remove an item from the rear of the queue\n");
            myQueue.removeRear();


            WriteLine($"Front of queue is {myQueue.peekFront()} ");
            WriteLine($"Rear of queue is {myQueue.peekRear()} ");

        }
    }

    //first make the Queue class
    public class Queue 
    {
        //set number of slots
        private int maxSize;
        // create an empty array of long integers for myQueue
        private long[] myQueue;
        // int for keeping track of the front, rear, and items in the Queue
        private int front;
        private int rear;
        private int items;

        //set initializations with constructor
        public Queue(int size) 
        {
            maxSize = size;
            myQueue = new long[size];

            //setting the possition
            front = 0;
            rear = -1;
            items = 0;

        }

        //next is inserting an item into the queue
        public void insert(long j) 
        {
            //safety check to see if full
            if (isFull())
            {
                WriteLine("Queue is full!");
            }
            else
            {
                if (rear == maxSize - 1)
                {
                    rear = -1;
                }
                rear++;
                myQueue[rear] = j;
                items++;
            }
        }

        //method to remove items from front of Queue
        public long removeFront() 
        {
            long temp = myQueue[front];
            front++;

            if (front == maxSize)
            {
                front = 0;
            }
            return temp;
        }

        //method to remove items from rear of Queue
        public long removeRear()
        {
            long temp = myQueue[rear];
            rear--;

            if (front == maxSize)
            {
                front = 0;
            }
            return temp;
        }



        //method to peek at the front
        public long peekFront() 
        {
            return myQueue[front];
        }

        //method to peek at the rear
        public long peekRear()
        {
            return myQueue[rear];
        }


        public bool isEmpty() {
            return (items == 0);
        }



        private bool isFull()
        {
            return (items == maxSize);
        }

        //method to view content
        public void view() {
            Write("[");

            for (int i = 0; i < myQueue.Length; i++)
            {
                Write(myQueue[i] + " ");
            }
            Write("]\n");
        }
    }
}
