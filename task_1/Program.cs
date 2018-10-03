/*
    Лабораторна робота №1
    Група: СБс-32
    Виконав: Цимбрак Назарій

 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> integers = new List<int>();
            for (int i = 0; i < 100; i++)
            {
                integers.Add(i);
            }

            /* Завдання №1*/
            Console.WriteLine("TASK 1");
            var time = DateTime.Now;
            foreach (var VARIABLE in integers)
            {
                Console.WriteLine("VAR: "+VARIABLE+" MULT: "+VARIABLE *2);
            }
            var timeOfProccess = DateTime.Now - time;
            Console.Write(" time: "+timeOfProccess+"\n");
            Console.Read();
            
        }

    }
}