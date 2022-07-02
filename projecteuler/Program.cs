using System;

namespace projecteuler
{
    class Program
    {
        static TasksList tasksList = new TasksList();

        static void Main(string[] args)
        {
            while (true)
            {
                start(Console.ReadLine());
            }
        }

        static void start(string taskNumber)
        {
            ITask task = tasksList.t_List[Convert.ToInt32(taskNumber) - 1];
            Console.WriteLine(task.answer());
        }
    }
}
