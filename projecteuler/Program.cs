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
                case "4":
                    var Task4 = new task_4();
                    Console.WriteLine(Task4.answer());
                    break;
                case "5":
                    var Task5 = new task_5();
                    Console.WriteLine(Task5.answer());
                    break;
                case "6":
                    var Task6 = new task_6();
                    Console.WriteLine(Task6.answer());
                    break;
                case "7":
                    var Task7 = new task_7();
                    Console.WriteLine(Task7.answer());
                    break;
            }
        }

    }
}
