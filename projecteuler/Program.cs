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
                    var Task_1 = new task_1();
                    Console.WriteLine(Task_1.answer());
                    break;
            }
        }

    }
}
