using System;

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
            ITask task;
            switch (taskNumber)
            {
                case "1":
                    task = new task_1();
                    Console.WriteLine(task.answer());
                    break;
                case "2":
                    task = new task_2();
                    Console.WriteLine(task.answer());
                    break;
                case "3":
                    task = new task_3();
                    Console.WriteLine(task.answer());
                    break;
                case "4":
                    task = new task_4();
                    Console.WriteLine(task.answer());
                    break;
                case "5":
                    task = new task_5();
                    Console.WriteLine(task.answer());
                    break;
                case "6":
                    task = new task_6();
                    Console.WriteLine(task.answer());
                    break;
                case "7":
                    task = new task_7();
                    Console.WriteLine(task.answer());
                    break;
                //case "8":
                //    task = new task_8();
                //    Console.WriteLine(task.answer());
                //    break;
            }
        }

    }
}
