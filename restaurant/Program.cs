using System;
using System.Collections.Generic;

// fråga.1 workerClass
//fråga.2 workers list, Name, Salary.
namespace Restaurant
{
    public class WorkerClass
    {
        public string Name { get; set; }
        public decimal Salary { get; set; }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            var workers = new List<WorkerClass>();

            while (true)
            {
                Console.WriteLine("1. Add a new worker");
                Console.WriteLine("2. Stop");
                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                {
                    Console.WriteLine("Write the name: ");
                    string name = Console.ReadLine();

                    Console.WriteLine("Write the salary: ");
                    decimal salary = Convert.ToDecimal(Console.ReadLine());

                    workers.Add(new WorkerClass { Name = name, Salary= salary });
                }
                else if (choice == 2)
                {
                    foreach (var worker in workers)
                    {
                        Console.WriteLine($"The worker name is {worker.Name} and the salary is {worker.Salary}kr");
                    }
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine($"please try again.");
                }

            }
        }
    }
}
