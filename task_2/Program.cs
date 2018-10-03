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
    
            threadProccess(4, 100);

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
            
            foreach (Thread item in threads)
            {
                item.Start();
            }
            foreach (Thread item in threads)
            {
                item.Abort();
            }
            
            
        }
        static void func(List<int> adds, int tr)
        {
            
            foreach (var VARIABLE in adds)
            {
                Console.WriteLine(tr+" VAR: "+VARIABLE+" MULT: "+VARIABLE *2+" _____t "+tr);
                Thread.Sleep(20);
            }
        }
    }
}