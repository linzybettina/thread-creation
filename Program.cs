using System;
using System.Collections.Generic;
using System.Threading;
using System.Text;

namespace ConsoleApplication1
{
    class ThreadTest
    {
        static void Main()
        {
            Thread t = new Thread(WriteY);
            t.Start();
            for (int i = 0; i < 20;i++)
                Console.Write("X");
        }
        static void WriteY()
        {
            for (int i = 0; i < 10; i++)
                Console.Write("y");
            Console.ReadLine();
        }
    }
}
