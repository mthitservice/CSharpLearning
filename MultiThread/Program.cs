 using System;
using System.Threading;
using System.Threading.Tasks;

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

            Task t1 = Task.Run(() => MultiTh.meth1());

            Console.WriteLine("Hello World!");
        }
    }
}
