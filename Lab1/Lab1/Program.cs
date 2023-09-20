using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MyThread t1 = new("1", 0, 10);
            MyThread t2 = new("2", 10, 20);
            MyThread t3 = new("3", 20, 30);
        }
    }
}