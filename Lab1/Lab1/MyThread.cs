using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Lab1
{
    public class MyThread
    {
        Thread thread;
        static object locker = new object();
        public MyThread(string name, int start, int end)
        {
            this.thread = new Thread(delegate() { this.Count(start, end); });
            thread.Name = name;
            this.thread.Start();
        }
        private void Count(int start, int end)
        {
            lock (locker)
            {
                for (int i = start; i < end; i++)
                    Console.WriteLine("Поток {0} выводит {1}", thread.Name, i);
            }
        }
    }
}