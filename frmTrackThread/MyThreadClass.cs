﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace frmTrackThread
{
    internal class MyThreadClass
    {
        public static void Thread1()
        {
            for (var i = 0; i < 3; i++)
            {
                Thread thread = Thread.CurrentThread;
                Console.WriteLine("Name of Thread: " + thread.Name + " = " + i);
                Thread.Sleep(500);
            }

        }

        public static void Thread2()
        {
            for (var i = 0; i < 6; i++)
            {
                Thread thread = Thread.CurrentThread;
                Console.WriteLine("Name of Thread: " + thread.Name + " = " + i);
                Thread.Sleep(1500);
            }
        }
    }
}
