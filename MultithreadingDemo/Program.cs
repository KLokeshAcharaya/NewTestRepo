using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultithreadingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //Use of Start() start here
            Thread ThreadObject1 = new Thread(Example1); //Creating the Thread    
            Thread ThreadObject2 = new Thread(Example2);
            ThreadObject1.Start(); //Starting the Thread    
            ThreadObject2.Start();
            //Use of Start() end here
            */
            /*
            //Use of Lock Start here  
            LockExample1 _locker = new LockExample1();
            Console.WriteLine("Threading with the help of Lock"); 
            Thread t1 = new Thread(new ThreadStart(_locker.Display));
            Thread t2 = new Thread(new ThreadStart(_locker.Display));
            t1.Start();     
            t2.Start();
            //Use of Lock End here
            */

            //Use of join start here    
            Thread ThreadObject1 = new Thread(WorkerThread);
            Console.WriteLine("Is thread 1 is alive : {0}", ThreadObject1.IsAlive); //Check thread alive
            ThreadObject1.Start();
            Console.WriteLine("Is thread 1 is alive : {0}", ThreadObject1.IsAlive); //Check thread alive
            ThreadObject1.Join(); //Using Join to block the current Thread    
            Console.WriteLine("1. MainThread Started");
            for (int i = 0; i <= 3; i++)
            {
                Console.WriteLine("-> MainThread Executing");
                Thread.Sleep(3000);    
            } 
            Thread Th = Thread.CurrentThread;
            Th.Name = "Main Thread";
            Console.WriteLine("\nGetting the Name of Currently running Thread");
            Console.WriteLine("Current Thread Name is: {0}",Th.Name);
            Console.WriteLine("Current Thread Priority is: {0}",Th.Priority);
            //Use of join end here
        }

        static void WorkerThread()
        {
            Console.WriteLine("2. WorkerThread Started");
            for (int i = 0; i <= 2; i++)
            {
                Console.WriteLine("-> WorkerThread Executing");
                Console.WriteLine("Child Thread Paused");
                Thread.Sleep(3000);
                Console.WriteLine("Child Thread Resumed");
            }
        }
        static void Example1()
        {
            Console.WriteLine("Thread1 Started");
            for (int i = 0; i <= 3; i++)
            {
                Console.WriteLine("Thread1 Executing");
                Thread.Sleep(5000); 
            }
        }
        static void Example2()
        {
            Console.WriteLine("Thread2 Started");
            for (int i = 0; i <= 3; i++)
            {
                Console.WriteLine("Thread2 Executing");
                Thread.Sleep(5000);
            }
        }
    }
    class LockExample1
    {
        //Creating a normal Method to Display Names    
        public void Display()
        {
            //Lock is used to lock-in the Current Thread    
            lock (this)
            {
                for (int i = 0; i <= 2; i++)
                {
                    Thread.Sleep(3000);
                    Console.WriteLine("My Name is Abhishek "+i);
                }
            }
        }
    }
}
