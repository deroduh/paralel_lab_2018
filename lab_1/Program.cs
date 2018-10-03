/*
    Лабораторна робота №1
    Група: СБс-32
    Виконав: Цимбрак Назарій

 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> integers = new List<int>();
            for (int i = 0; i < 30; i++)
            {
                integers.Add(i);
            }
            
            var evensAndOdds = integers.GroupBy(x => x % 2);
            
            var evens = evensAndOdds.Where(g => g.Key == 0).SelectMany(g => g).ToList();
            var adds =  evensAndOdds.Where(g => g.Key == 1).SelectMany(g => g).ToList();
            
            /* Завдання №1*/
            Console.WriteLine("TASK 1");
            foreach (var VARIABLE in integers)
            {
                Console.WriteLine("VAR: "+VARIABLE+" MULT: "+VARIABLE *2);
            }

			    


    }
}