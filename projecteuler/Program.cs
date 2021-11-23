﻿using System;

namespace projecteuler
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                start(Console.ReadLine());
            }
        }

        static void start(string taskNumber)
        {
            switch (taskNumber)
            {
                case "1":
                    var Task1 = new task_1();
                    Console.WriteLine(Task1.answer());
                    break;
                case "2":
                    var Task2 = new task_2();
                    Console.WriteLine(Task2.answer());
                    break;
                case "3":
                    var Task3 = new task_3();
                    Console.WriteLine(Task3.answer());
                    break;
            }
        }

    }
}