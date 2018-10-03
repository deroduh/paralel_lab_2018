/*
    Лабораторна робота №1
    Група: СБс-32
    Виконав: Цимбрак Назарій

 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 6; i++)
            {
                for (int j = 10; j <= 100000; j*=10)
                {
                    Console.Write("i: "+i+" j: "+j);
                    threadProccess(i, j);
                }
            }
            
            
            
            Console.Read();
        }

        static void threadProccess(int threadCount, int itemNumber)
        {
            List<int> integers = new List<int>();
            List<Thread> threads= new List<Thread>();
            
            for (int i = 0; i < itemNumber; i++)
            {
                integers.Add(i);
            }
            
            int c = 0;
            integers.GroupBy(x => c++ / threadCount).ToArray();
           
            var list = new List<List<int>>(); 

            for (int i=0; i < integers.Count; i+= threadCount) 
            { 
                list.Add(integers.GetRange(i, Math.Min(threadCount, integers.Count - i))); 
            } 
            
         
            foreach (var item in list)
            {
                threads.Add(new Thread(() => func(item, list.IndexOf(item))));
            }
            var time = DateTime.Now;
            foreach (Thread item in threads)
            {
                item.Start();
            }
            foreach (Thread item in threads)
            {
                item.Abort();
            }
            var timeOfProccess = DateTime.Now - time;
            Console.Write(" time: "+timeOfProccess+"\n");
//            Console.WriteLine("Time of threads");
            
            
        }
        static void func(List<int> adds, int tr)
        {
            
            foreach (var item in adds)
            {
                int a = item*2;
//                Console.WriteLine(tr+" VAR: "+item+" MULT: "+item*2+" _____t "+tr);
                Thread.Sleep(20);
            }
        }
    }
}