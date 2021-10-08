 using System;
using System.Threading;

namespace MultiThread
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thr1 =new Thread(MultiTh.meth1);
            Thread thr2 = new Thread(MultiTh.meth2);
            Thread mt = Thread.CurrentThread;
            mt.Name = "Test";

            thr1.Start();
            thr2.Start();

            Console.WriteLine("Hello World!");
        }
    }
}
