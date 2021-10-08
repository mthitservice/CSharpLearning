using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MultiThread
{
   public  class MultiTh
    {

        public static void meth1()
        {
    for (int i=0;i<=10;i++)
            {
                Console.WriteLine("meth1 is:{0}", i);
                if (i==5)
                {
                    Thread.Sleep(6000);

                }

            }

        }
        public static void meth2() {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("meth2 is:{0}", i);
              
            }

}
    }
}
