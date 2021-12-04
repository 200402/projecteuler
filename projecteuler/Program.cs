using System;

namespace projecteuler
{
    class Program
    {
        static ITask[] TasksList = new ITask[]
        {
             new task_1(),
             new task_2(),
             new task_3(),
             new task_4(),
             new task_5(),
             new task_6(),
             new task_7(),
             new task_8()
        };

        static void Main(string[] args)
        {

            while (true)
            {
                start(Console.ReadLine());
            }
        }

        static void start(string taskNumber)
        {
            ITask task = TasksList[Convert.ToInt32(taskNumber)];
            Console.WriteLine(task.answer());
        }
    }
}
